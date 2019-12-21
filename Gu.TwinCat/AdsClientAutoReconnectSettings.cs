namespace Gu.TwinCat
{
    using System;
    using System.Threading;
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
        /// <param name="reconnectInterval">The time between checks and attempts to reconnect.</param>
        /// <param name="inactiveSymbolHandling">The <see cref="TwinCat.InactiveSymbolHandling"/>.</param>
        public AdsClientAutoReconnectSettings(AmsAddress? address, AdsTimeSpan reconnectInterval, InactiveSymbolHandling inactiveSymbolHandling)
             : base(address, inactiveSymbolHandling)
        {
            this.ReconnectInterval = reconnectInterval;
        }

        /// <summary>
        /// The interval between checks and reconnects.
        /// </summary>
        public AdsTimeSpan ReconnectInterval { get; }

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
                this.reconnectTimer = new Timer(this.OnElapsed, null, 0, settings.ReconnectInterval.Milliseconds);
            }

            public void Dispose()
            {
                if (this.disposed)
                {
                    return;
                }

                this.disposed = true;
                this.reconnectTimer.Dispose();
            }

            private void OnElapsed(object? state)
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
        }
    }
}
