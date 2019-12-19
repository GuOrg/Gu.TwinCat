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
        private readonly Func<AdsBinaryReader, int, TPlc> read;
        private bool disposed;

        private int handle;
        private Maybe<TCsharp> value;
        private DateTimeOffset lastUpdateTime;
        private TimeSpan notifyTime;
        private Exception? exception;

        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription{TPlc, TCsharp}"/> class.
        /// </summary>
        /// <param name="client">The <see cref="IAdsConnection"/>.</param>
        /// <param name="symbol">The <see cref="ReadFromAdsSymbol{TPlc, TCsharp}"/>.</param>
        /// <param name="read">Example (reader, _) => reader.ReadUint32().</param>
        /// <param name="transMode">Specifies if the event should be fired cyclically or only if the variable has changed.</param>
        /// <param name="cycleTime">The ADS server checks whether the variable has changed after this time interval.</param>
        /// <param name="maxDelay">The AdsNotification event is fired at the latest when this time has elapsed.</param>
        public Subscription(IAdsConnection client, ReadFromAdsSymbol<TPlc, TCsharp> symbol, Func<AdsBinaryReader, int, TPlc> read, AdsTransMode transMode, AdsTimeSpan cycleTime, AdsTimeSpan maxDelay)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
            this.read = read;
            this.Symbol = symbol;
            this.TransMode = transMode;
            this.CycleTime = cycleTime;
            this.MaxDelay = maxDelay;

            if (symbol.IsActive)
            {
                this.client.AdsNotificationEx += this.OnAdsNotificationEx;
                this.client.ConnectionStateChanged += this.OnConnectionStateChanged;
                this.handle = this.client.AddDeviceNotificationEx(symbol.Name, transMode, cycleTime.Milliseconds, maxDelay.Milliseconds, null, typeof(TPlc));
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
            get => this.value;
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
        /// The exception thrown in AdsClient.AdsNotification handler.
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
                this.client.DeleteDeviceNotification(this.handle);
                this.client.AdsNotificationEx -= this.OnAdsNotificationEx;
                this.client.ConnectionStateChanged -= this.OnConnectionStateChanged;
            }
        }

        private void OnAdsNotificationEx(object sender, AdsNotificationExEventArgs e)
        {
            if (e.NotificationHandle == this.handle)
            {
                try
                {
                    var time = DateTimeOffset.UtcNow;
                    this.Value = Maybe.Some(this.Symbol.Map((TPlc)e.Value));
                    this.LastUpdateTime = time;
                    this.NotifyTime = DateTimeOffset.UtcNow - time;
                    this.Exception = null;
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
            switch (e.NewState)
            {
                case ConnectionState.Connected:
                    if (this.Symbol.IsActive)
                    {
                        this.handle = this.client.AddDeviceNotificationEx(this.Symbol.Name, this.TransMode, this.CycleTime.Milliseconds, this.MaxDelay.Milliseconds, null, typeof(TPlc));
                    }

                    return;
                case ConnectionState.None:
                case ConnectionState.Lost:
                case ConnectionState.Disconnected:
                    this.LastUpdateTime = DateTimeOffset.UtcNow;
                    this.Value = Maybe.None<TCsharp>();
                    break;
                default:
                    throw new InvalidEnumArgumentException(nameof(e), (int)e.NewState, typeof(ConnectionState));
            }
        }

        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
