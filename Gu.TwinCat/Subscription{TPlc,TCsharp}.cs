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
        private readonly IAdsConnection connection;
        private bool disposed;
        private int handle = -1;
        private Maybe<TCsharp> value;
        private DateTimeOffset lastUpdateTime;
        private TimeSpan lastNotifyDuration;
        private UpdateTrigger lastTrigger;
        private Exception? lastException;

        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription{TPlc, TCsharp}"/> class.
        /// </summary>
        /// <param name="connection">The <see cref="IAdsConnection"/>.</param>
        /// <param name="symbol">The <see cref="ReadFromAdsSymbol{TPlc, TCsharp}"/>.</param>
        /// <param name="transMode">Specifies if the event should be fired cyclically or only if the variable has changed.</param>
        /// <param name="cycleTime">The ADS server checks whether the variable has changed after this time interval.</param>
        /// <param name="maxDelay">The AdsNotification event is fired at the latest when this time has elapsed.</param>
        public Subscription(IAdsConnection connection, ReadFromAdsSymbol<TPlc, TCsharp> symbol, AdsTransMode transMode, AdsTimeSpan cycleTime, AdsTimeSpan maxDelay)
        {
            this.connection = connection ?? throw new ArgumentNullException(nameof(connection));
            this.Symbol = symbol;
            this.TransMode = transMode;
            this.CycleTime = cycleTime;
            this.MaxDelay = maxDelay;

            if (symbol.IsActive)
            {
                connection.AdsNotificationEx += this.OnAdsNotificationEx;
                connection.ConnectionStateChanged += this.OnConnectionStateChanged;

                if (connection is TcAdsClient adsClient)
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
        public TimeSpan LastNotifyDuration
        {
            get => this.lastNotifyDuration;
            set
            {
                if (value == this.lastNotifyDuration)
                {
                    return;
                }

                this.lastNotifyDuration = value;
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
        /// The last <see cref="LastException"/>.
        /// </summary>
        public Exception? LastException
        {
            get => this.lastException;
            set
            {
                if (ReferenceEquals(value, this.lastException))
                {
                    return;
                }

                this.lastException = value;
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
                                this.connection.DeleteDeviceNotification(this.handle);
                                this.handle = -1;
                            }
#pragma warning disable CA1031 // Do not catch general exception types
                            catch (Exception e)
#pragma warning restore CA1031 // Do not catch general exception types
                            {
                                this.LastException = e;
                            }
                        }
                    }
                }

                if (this.connection is TcAdsClient adsClient)
                {
                    adsClient.AdsStateChanged -= this.OnAdsStateChanged;
                }

                this.connection.AdsNotificationEx -= this.OnAdsNotificationEx;
                this.connection.ConnectionStateChanged -= this.OnConnectionStateChanged;
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
                        Maybe.Some(this.Symbol.Map((TPlc)this.connection.ReadSymbol(this.Symbol.Name, typeof(TPlc), reloadSymbolInfo: false))),
                        UpdateTrigger.Refresh);
                }
#pragma warning disable CA1031 // Do not catch general exception types
                catch (Exception ex)
#pragma warning restore CA1031 // Do not catch general exception types
                {
                    this.LastException = ex;
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
                this.LastNotifyDuration = DateTimeOffset.UtcNow - time;
                this.LastTrigger = trigger;
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception e)
#pragma warning restore CA1031 // Do not catch general exception types
            {
                this.LastException = e;
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
                if (this.connection.IsConnected &&
                    this.connection.TryReadState(out var state) == AdsErrorCode.NoError &&
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
                            this.handle = this.connection.AddDeviceNotificationEx(this.Symbol.Name, this.TransMode, this.CycleTime.Milliseconds, this.MaxDelay.Milliseconds, null, typeof(TPlc));
                        }
#pragma warning disable CA1031 // Do not catch general exception types
                        catch (Exception e)
#pragma warning restore CA1031 // Do not catch general exception types
                        {
                            this.LastException = e;
                        }
                    }
                    else if (typeof(TPlc) == typeof(string))
                    {
                        try
                        {
                            var tcAdsSymbol = this.connection.ReadSymbolInfo(this.Symbol.Name);
                            var size = tcAdsSymbol.Size;
                            this.handle = this.connection.AddDeviceNotificationEx(this.Symbol.Name, this.TransMode, this.CycleTime.Milliseconds, this.MaxDelay.Milliseconds, null, typeof(TPlc), new[] { size });
                        }
#pragma warning disable CA1031 // Do not catch general exception types
                        catch (Exception e)
#pragma warning restore CA1031 // Do not catch general exception types
                        {
                            this.LastException = e;
                        }
                    }
                    else if (typeof(TPlc) is { IsArray: true, HasElementType: true } arrayType &&
                             arrayType.GetElementType() is { IsValueType: true } elementType)
                    {
                        try
                        {
                            var tcAdsSymbol = this.connection.ReadSymbolInfo(this.Symbol.Name);
                            var size = tcAdsSymbol.Size / Marshal.SizeOf(elementType);
                            this.handle = this.connection.AddDeviceNotificationEx(this.Symbol.Name, this.TransMode, this.CycleTime.Milliseconds, this.MaxDelay.Milliseconds, null, typeof(TPlc), new[] { size });
                        }
#pragma warning disable CA1031 // Do not catch general exception types
                        catch (Exception e)
#pragma warning restore CA1031 // Do not catch general exception types
                        {
                            this.LastException = e;
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
                            _ = this.connection.TryDeleteDeviceNotification((uint)this.handle);
                        }
#pragma warning disable CA1031 // Do not catch general exception types
                        catch (Exception e)
#pragma warning restore CA1031 // Do not catch general exception types
                        {
                            this.LastException = e;
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
                    this.LastException = ex;
                }
            }
        }

        private void OnConnectionStateChanged(object sender, ConnectionStateChangedEventArgs e)
        {
            this.UpdateSubscription();
        }

        private void OnAdsStateChanged(object sender, AdsStateChangedEventArgs e)
        {
            this.UpdateSubscription();
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
