namespace Gu.TwinCat
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using TwinCAT;
    using TwinCAT.Ads;

    /// <summary>
    /// A subscription for values from PLC fro a <see cref="ReadFromAdsSymbol{TPlc,TCsharp}"/>.
    /// </summary>
    /// <typeparam name="TPlc">The PLC type.</typeparam>
    /// <typeparam name="TCsharp">The c# type.</typeparam>
    public sealed class Subscription<TPlc, TCsharp> : IDisposable, INotifyPropertyChanged
    {
        private readonly object gate = new object();
        private readonly IAdsConnection client;
        private bool disposed;
        private int handle = -1;
        private Maybe<TCsharp> value;
        private DateTimeOffset lastUpdateTime;
        private TimeSpan lastNotifyTime;
        private UpdateTrigger lastTrigger;
        private Exception? exception;

        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription{TPlc, TCsharp}"/> class.
        /// </summary>
        /// <param name="client">The <see cref="IAdsConnection"/>.</param>
        /// <param name="symbol">The <see cref="ReadFromAdsSymbol{TPlc, TCsharp}"/>.</param>
        /// <param name="transMode">Specifies if the event should be fired cyclically or only if the variable has changed.</param>
        /// <param name="cycleTime">The ADS server checks whether the variable has changed after this time interval.</param>
        /// <param name="maxDelay">The AdsNotification event is fired at the latest when this time has elapsed.</param>
        public Subscription(IAdsConnection client, ReadFromAdsSymbol<TPlc, TCsharp> symbol, AdsTransMode transMode, AdsTimeSpan cycleTime, AdsTimeSpan maxDelay)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
            this.Symbol = symbol;
            this.TransMode = transMode;
            this.CycleTime = cycleTime;
            this.MaxDelay = maxDelay;

            if (symbol.IsActive)
            {
                client.AdsNotificationEx += this.OnAdsNotificationEx;
                client.ConnectionStateChanged += this.OnConnectionStateChanged;

                if (client is TcAdsClient adsClient)
                {
                    adsClient.AdsStateChanged += this.OnAdsStateChanged;
                }

                this.UpdateSubscription();
            }
            else
            {
                this.value = Maybe.Some(symbol.Map(default!));
            }
        }

        /// <inheritdoc />
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// The <see cref="ReadFromAdsSymbol{TPlc, TCsharp}"/>.
        /// </summary>
        public ReadFromAdsSymbol<TPlc, TCsharp> Symbol { get; }

        /// <summary>
        /// Specifies if the event should be fired cyclically or only if the variable has changed.
        /// </summary>
        public AdsTransMode TransMode { get; }

        /// <summary>
        /// The ADS server checks whether the variable has changed after this time interval.
        /// </summary>
        public AdsTimeSpan CycleTime { get; }

        /// <summary>
        /// The AdsNotification event is fired at the latest when this time has elapsed.
        /// </summary>
        public AdsTimeSpan MaxDelay { get; }

        /// <summary>
        /// The last received value.
        /// </summary>
        public Maybe<TCsharp> Value
        {
            get
            {
                this.ThrowIfDisposed();
                return this.value;
            }

            private set
            {
                if (value == this.value)
                {
                    return;
                }

                this.value = value;
                this.OnPropertyChanged();
            }
        }

        /// <summary>
        /// The time of last received value.
        /// </summary>
        public DateTimeOffset LastUpdateTime
        {
            get => this.lastUpdateTime;
            set
            {
                if (value == this.lastUpdateTime)
                {
                    return;
                }

                this.lastUpdateTime = value;
                this.OnPropertyChanged();
            }
        }

        /// <summary>
        /// The time the event handler for <see cref="Value"/> and <see cref="LastUpdateTime"/> took.
        /// Mostly for debug purposes.
        /// </summary>
        public TimeSpan LastNotifyTime
        {
            get => this.lastNotifyTime;
            set
            {
                if (value == this.lastNotifyTime)
                {
                    return;
                }

                this.lastNotifyTime = value;
                this.OnPropertyChanged();
            }
        }

        /// <summary>
        /// The reason for the last update of <see cref="Value"/>.
        /// </summary>
        public UpdateTrigger LastTrigger
        {
            get => this.lastTrigger;
            private set
            {
                if (value == this.lastTrigger)
                {
                    return;
                }

                this.lastTrigger = value;
                this.OnPropertyChanged();
            }
        }

        /// <summary>
        /// The last <see cref="Exception"/>.
        /// </summary>
        public Exception? Exception
        {
            get => this.exception;
            set
            {
                if (ReferenceEquals(value, this.exception))
                {
                    return;
                }

                this.exception = value;
                this.OnPropertyChanged();
            }
        }

        /// <inheritdoc />
        public void Dispose()
        {
            if (this.disposed)
            {
                return;
            }

            this.disposed = true;
            if (this.Symbol.IsActive)
            {
                if (this.handle >= 0)
                {
                    lock (this.gate)
                    {
                        if (this.handle >= 0)
                        {
                            try
                            {
                                this.client.DeleteDeviceNotification(this.handle);
                                this.handle = -1;
                            }
#pragma warning disable CA1031 // Do not catch general exception types
                            catch (Exception e)
#pragma warning restore CA1031 // Do not catch general exception types
                            {
                                this.Exception = e;
                            }
                        }
                    }
                }

                if (this.client is TcAdsClient adsClient)
                {
                    adsClient.AdsStateChanged -= this.OnAdsStateChanged;
                }

                this.client.AdsNotificationEx -= this.OnAdsNotificationEx;
                this.client.ConnectionStateChanged -= this.OnConnectionStateChanged;
            }
        }

        /// <summary>
        /// Force a read from PLC.
        /// </summary>
        public void Refresh()
        {
            if (this.Symbol.IsActive)
            {
                try
                {
                    this.UpdateValue(
                        Maybe.Some(this.Symbol.Map((TPlc)this.client.ReadSymbol(this.Symbol.Name, typeof(TPlc), reloadSymbolInfo: false))),
                        UpdateTrigger.Refresh);
                }
#pragma warning disable CA1031 // Do not catch general exception types
                catch (Exception ex)
#pragma warning restore CA1031 // Do not catch general exception types
                {
                    this.Exception = ex;
                }
            }
            else
            {
                this.UpdateValue(Maybe.Some(this.Symbol.Map(default!)), UpdateTrigger.Refresh);
            }
        }

        private void UpdateValue(Maybe<TCsharp> newValue, UpdateTrigger trigger)
        {
            try
            {
                var time = DateTimeOffset.UtcNow;
                this.Value = newValue;
                this.LastUpdateTime = time;
                this.LastNotifyTime = DateTimeOffset.UtcNow - time;
                this.LastTrigger = trigger;
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception e)
#pragma warning restore CA1031 // Do not catch general exception types
            {
                this.Exception = e;
            }
        }

        private void UpdateSubscription()
        {
            if (this.disposed)
            {
                return;
            }

            lock (this.gate)
            {
                if (this.client.IsConnected &&
                    this.client.TryReadState(out var state) == AdsErrorCode.NoError &&
                    state.AdsState == AdsState.Run)
                {
                    if (this.handle >= 0)
                    {
                        return;
                    }

                    if (typeof(TPlc).IsValueType)
                    {
                        try
                        {
                            this.handle = this.client.AddDeviceNotificationEx(this.Symbol.Name, this.TransMode, this.CycleTime.Milliseconds, this.MaxDelay.Milliseconds, null, typeof(TPlc));
                        }
#pragma warning disable CA1031 // Do not catch general exception types
                        catch (Exception e)
#pragma warning restore CA1031 // Do not catch general exception types
                        {
                            this.Exception = e;
                        }
                    }
                    else if (typeof(TPlc) == typeof(string))
                    {
                        try
                        {
                            var tcAdsSymbol = this.client.ReadSymbolInfo(this.Symbol.Name);
                            var size = tcAdsSymbol.Size;
                            this.handle = this.client.AddDeviceNotificationEx(this.Symbol.Name, this.TransMode, this.CycleTime.Milliseconds, this.MaxDelay.Milliseconds, null, typeof(TPlc), new[] { size });
                        }
#pragma warning disable CA1031 // Do not catch general exception types
                        catch (Exception e)
#pragma warning restore CA1031 // Do not catch general exception types
                        {
                            this.Exception = e;
                        }
                    }
                    else if (typeof(TPlc) is { IsArray: true, HasElementType: true } arrayType &&
                             arrayType.GetElementType() is { IsValueType: true } elementType)
                    {
                        try
                        {
                            var tcAdsSymbol = this.client.ReadSymbolInfo(this.Symbol.Name);
                            var size = tcAdsSymbol.Size / Marshal.SizeOf(elementType);
                            this.handle = this.client.AddDeviceNotificationEx(this.Symbol.Name, this.TransMode, this.CycleTime.Milliseconds, this.MaxDelay.Milliseconds, null, typeof(TPlc), new[] { size });
                        }
#pragma warning disable CA1031 // Do not catch general exception types
                        catch (Exception e)
#pragma warning restore CA1031 // Do not catch general exception types
                        {
                            this.Exception = e;
                        }
                    }
                    else
                    {
                        throw new NotSupportedException($"Cannot subscribe to the type {typeof(TPlc)}.");
                    }
                }
                else
                {
                    if (this.handle >= 0)
                    {
                        try
                        {
                            _ = this.client.TryDeleteDeviceNotification((uint)this.handle);
                        }
#pragma warning disable CA1031 // Do not catch general exception types
                        catch (Exception e)
#pragma warning restore CA1031 // Do not catch general exception types
                        {
                            this.Exception = e;
                        }
                    }

                    this.handle = -1;
                    this.UpdateValue(Maybe.None<TCsharp>(), UpdateTrigger.StateChanged);
                }
            }
        }

        private void OnAdsNotificationEx(object sender, AdsNotificationExEventArgs e)
        {
            if (e.NotificationHandle == this.handle)
            {
                try
                {
                    this.UpdateValue(Maybe.Some(this.Symbol.Map((TPlc)e.Value)), UpdateTrigger.AdsNotificationEx);
                }
#pragma warning disable CA1031 // Do not catch general exception types
                catch (Exception ex)
#pragma warning restore CA1031 // Do not catch general exception types
                {
                    this.Exception = ex;
                }
            }
        }

        private void OnConnectionStateChanged(object sender, ConnectionStateChangedEventArgs e)
        {
            Debug.WriteLine($"OnConnectionStateChanged before UpdateSubscription IsConnected: {this.client.IsConnected}, AdsState: {((AdsClient)this.client).AdsState}, handle: {this.handle}");
            this.UpdateSubscription();
            Debug.WriteLine($"OnConnectionStateChanged after UpdateSubscription IsConnected: {this.client.IsConnected}, AdsState: {((AdsClient)this.client).AdsState}, handle: {this.handle}");
        }

        private void OnAdsStateChanged(object sender, AdsStateChangedEventArgs e)
        {
            Debug.WriteLine($"OnAdsStateChanged before UpdateSubscription IsConnected: {this.client.IsConnected}, AdsState: {((AdsClient)this.client).AdsState}, handle: {this.handle}");
            this.UpdateSubscription();
            Debug.WriteLine($"OnAdsStateChanged after UpdateSubscription IsConnected: {this.client.IsConnected}, AdsState: {((AdsClient)this.client).AdsState}, handle: {this.handle}");
        }

        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ThrowIfDisposed()
        {
            if (this.disposed)
            {
                throw new ObjectDisposedException(typeof(Subscription<TPlc, TCsharp>).FullName);
            }
        }
    }
}
