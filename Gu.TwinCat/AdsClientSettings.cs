namespace Gu.TwinCat
{
    using System;
    using System.ComponentModel;
    using TwinCAT.Ads;

    /// <summary>
    /// Base class for setting for <see cref="AdsClient"/>.
    /// </summary>
    public abstract class AdsClientSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdsClientSettings"/> class.
        /// </summary>
        /// <param name="address">The <see cref="AmsAddress"/>.</param>
        /// <param name="inactiveSymbolHandling">The <see cref="TwinCat.InactiveSymbolHandling"/>.</param>
        protected AdsClientSettings(AmsAddress? address, InactiveSymbolHandling inactiveSymbolHandling)
        {
            if (!Enum.IsDefined(typeof(InactiveSymbolHandling), inactiveSymbolHandling))
            {
                throw new InvalidEnumArgumentException(nameof(inactiveSymbolHandling), (int)inactiveSymbolHandling, typeof(InactiveSymbolHandling));
            }

            this.Address = address;
            this.InactiveSymbolHandling = inactiveSymbolHandling;
        }

        /// <summary>
        /// The <see cref="AmsAddress"/>.
        /// </summary>
        public AmsAddress? Address { get; }

        /// <summary>
        /// Specifies how this instance handles inactive symbols.
        /// </summary>
        public InactiveSymbolHandling InactiveSymbolHandling { get; }

        /// <summary>
        /// Create a listener that manages reconnects etc.
        /// </summary>
        /// <param name="client">The <see cref="AdsClient"/>.</param>
        /// <returns>A new listener.</returns>
        public abstract IDisposable CreateListener(AdsClient client);
    }
}
