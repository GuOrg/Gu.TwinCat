namespace Gu.TwinCat
{
    using System;
    using System.Timers;
    using TwinCAT.Ads;

    /// <summary>
    /// For creating a clinet that reconnects automatically.
    /// </summary>
    public class AdsClientAutoReconnectSettings : AdsClientSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdsClientAutoReconnectSettings"/> class.
        /// </summary>
        /// <param name="address">The <see cref="AmsAddress"/>.</param>
        /// <param name="reconnectInterval">The <see cref="TimeSpan"/>.</param>
        /// <param name="inactiveSymbolHandling">The <see cref="TwinCat.InactiveSymbolHandling"/>.</param>
        public AdsClientAutoReconnectSettings(AmsAddress? address, TimeSpan reconnectInterval, InactiveSymbolHandling inactiveSymbolHandling)
             : base(address, inactiveSymbolHandling)
        {
            this.ReconnectInterval = reconnectInterval;
        }

        /// <summary>
        /// The interval between checks and reconnects.
        /// </summary>
        public TimeSpan ReconnectInterval { get; }

        /// <summary>
        /// Create a listener that manages reconnects etc.
        /// </summary>
        /// <param name="client">The <see cref="AdsClient"/>.</param>
        /// <returns>A new listener.</returns>
        public override IDisposable CreateListener(AdsClient client)
        {
            if (client is null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            return new Listener(client, this);
        }

        private sealed class Listener : IDisposable
        {
            private readonly AdsClient client;
            private readonly AdsClientAutoReconnectSettings settings;
            private readonly Timer reconnectTimer;
            private bool disposed;

            internal Listener(AdsClient client, AdsClientAutoReconnectSettings settings)
            {
                this.client = client;
                this.settings = settings;
                this.OnElapsed(null, null!);
                client.AmsRouterNotification += this.OnAmsRouterNotification;
                this.reconnectTimer = new Timer(settings.ReconnectInterval.TotalMilliseconds);
                this.reconnectTimer.Elapsed += this.OnElapsed;
                this.reconnectTimer.Start();
            }

            public void Dispose()
            {
                if (this.disposed)
                {
                    return;
                }

                this.disposed = true;
                this.reconnectTimer.Elapsed -= this.OnElapsed;
                this.client.AmsRouterNotification -= this.OnAmsRouterNotification;
                this.reconnectTimer.Dispose();
            }

            private void OnElapsed(object? sender, ElapsedEventArgs e)
            {
                if (!this.client.IsConnected)
                {
                    if (this.client.Address is { } address)
                    {
                        this.client.Connect(address);
                    }
                    else if (this.settings.Adress is { } settingsAddress)
                    {
                        this.client.Connect(settingsAddress);
                    }
                }
            }

            private void OnAmsRouterNotification(object sender, TwinCAT.Ads.AmsRouterNotificationEventArgs e)
            {
                if (this.client.IsConnected)
                {
                    if (this.client.Disconnect())
                    {
                        this.client.Connect(this.client.Address);
                    }
                }
            }
        }
    }
}
