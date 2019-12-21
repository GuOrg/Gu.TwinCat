namespace Gu.TwinCat
{
    using System.ComponentModel;
    using TwinCAT;
    using TwinCAT.Ads;

    /// <summary>ADS Client / ADS Communication object.</summary>
    public interface IAdsClient : IConnection, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the current state of the local AMS Router.
        /// </summary>
        public AmsRouterState RouterState { get; }

        /// <summary>
        /// The current <see cref="AdsState"/>.
        /// </summary>
        public AdsState AdsState { get; }

        /// <summary>Establishes a connection to a ADS device.</summary>
        /// <param name="netId">NetId of the ADS server.</param>
        /// <param name="srvPort">Port number of the ADS server.</param>
        void Connect(string netId, int srvPort);

        /// <summary>
        /// Reads the value of a symbol and returns the value as object. The parameter type must have the same
        /// layout as the ADS symbol.
        /// </summary>
        /// <typeparam name="TPlc">The PLC type.</typeparam>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="symbol">The <see cref="ReadFromAdsSymbol{TPlc,TCsharp}"/>.</param>
        /// <returns>Value of the symbol.</returns>
        TCsharp Read<TPlc, TCsharp>(ReadFromAdsSymbol<TPlc, TCsharp> symbol);

        /// <summary>
        /// Reads the value of a symbol and returns the value as object. The parameter type must have the same
        /// layout as the ADS symbol.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <typeparam name="TPlc">The PLC type.</typeparam>
        /// <param name="symbol">The <see cref="WriteToAdsSymbol{TCsharp,TPlc}"/>.</param>
        /// <param name="value">The value.</param>
        void Write<TCsharp, TPlc>(WriteToAdsSymbol<TCsharp, TPlc> symbol, TCsharp value);

        /// <summary>
        /// Creates a new instance of the <see cref="Subscription{TPlc, TCsharp}"/> class.
        /// </summary>
        /// <typeparam name="TPlc">The PLC type.</typeparam>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="symbol">The <see cref="ReadFromAdsSymbol{TPlc, TCsharp}"/>.</param>
        /// <param name="transMode">Specifies if the event should be fired cyclically or only if the variable has changed.</param>
        /// <param name="cycleTime">The ADS server checks whether the variable has changed after this time interval.</param>
        /// <param name="maxDelay">The AdsNotification event is fired at the latest when this time has elapsed.</param>
        /// <returns>A new instance of the <see cref="Subscription{Single, TCsharp}"/> class.</returns>
        Subscription<TPlc, TCsharp> Subscribe<TPlc, TCsharp>(ReadFromAdsSymbol<TPlc, TCsharp> symbol, AdsTransMode transMode, AdsTimeSpan cycleTime, AdsTimeSpan maxDelay = default);
    }
}
