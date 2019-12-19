namespace Gu.TwinCat
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using TwinCAT;
    using TwinCAT.Ads;

    /// <summary>
    /// A subscription for values from PLC fro a <see cref="ReadFromAdsSymbol{TPlc,TCsharp}"/>.
    /// </summary>
    /// <typeparam name="TPlc">The PLC type.</typeparam>
    /// <typeparam name="TCsharp">The c# type.</typeparam>
    public sealed class Subscription<TPlc, TCsharp> : IDisposable, INotifyPropertyChanged
    {
        private readonly IAdsConnection client;
        private bool disposed;
        private int handle = -1;
        private Maybe<TCsharp> value;
        private DateTimeOffset lastUpdateTime;
        private TimeSpan notifyTime;
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
                this.client.AdsNotificationEx += this.OnAdsNotificationEx;
                this.client.ConnectionStateChanged += this.OnConnectionStateChanged;
                if (client.IsConnected)
                {
                    try
                    {
                        this.handle = this.client.AddDeviceNotificationEx(symbol.Name, transMode, cycleTime.Milliseconds, maxDelay.Milliseconds, null, typeof(TPlc));
                    }
#pragma warning disable CA1031 // Do not catch general exception types
                    catch (Exception ex)
#pragma warning restore CA1031 // Do not catch general exception types
                    {
                        this.exception = ex;
                    }
                }
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
        public TimeSpan NotifyTime
        {
            get => this.notifyTime;
            set
            {
                if (value == this.notifyTime)
                {
                    return;
                }

                this.notifyTime = value;
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
                try
                {
                    this.client.DeleteDeviceNotification(this.handle);
                }
#pragma warning disable CA1031 // Do not catch general exception types
                catch (Exception e)
#pragma warning restore CA1031 // Do not catch general exception types
                {
                    this.Exception = e;
                }

                this.client.AdsNotificationEx -= this.OnAdsNotificationEx;
                this.client.ConnectionStateChanged -= this.OnConnectionStateChanged;
            }
        }

        private void UpdateValue(Maybe<TCsharp> newValue)
        {
            try
            {
                var time = DateTimeOffset.UtcNow;
                this.Value = newValue;
                this.LastUpdateTime = time;
                this.NotifyTime = DateTimeOffset.UtcNow - time;
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception e)
#pragma warning restore CA1031 // Do not catch general exception types
            {
                this.Exception = e;
            }
        }

        private void OnAdsNotificationEx(object sender, AdsNotificationExEventArgs e)
        {
            if (e.NotificationHandle == this.handle)
            {
                try
                {
                    this.UpdateValue(Maybe.Some(this.Symbol.Map((TPlc)e.Value)));
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
            switch (e.Reason)
            {
                case ConnectionStateChangedReason.None:
                    break;
                case ConnectionStateChangedReason.Established:
                    if (this.Symbol.IsActive)
                    {
                        try
                        {
                            this.handle = this.client.AddDeviceNotificationEx(this.Symbol.Name, this.TransMode, this.CycleTime.Milliseconds, this.MaxDelay.Milliseconds, null, typeof(TPlc));
                        }
#pragma warning disable CA1031 // Do not catch general exception types
                        catch (Exception ex)
#pragma warning restore CA1031 // Do not catch general exception types
                        {
                            this.Exception = ex;
                        }
                    }

                    break;
                case ConnectionStateChangedReason.Closed:
                case ConnectionStateChangedReason.Lost:
                case ConnectionStateChangedReason.Error:
                    this.UpdateValue(Maybe.None<TCsharp>());
                    break;
                case ConnectionStateChangedReason.Resurrected:
                    break;
                default:
                    throw new InvalidEnumArgumentException(nameof(e), (int)e.Reason, typeof(ConnectionStateChangedReason));
            }
        }

        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ThrowIfDisposed()
        {
            if (this.disposed)
            {
                throw new ObjectDisposedException(this.GetType().FullName);
            }
        }
    }
}
