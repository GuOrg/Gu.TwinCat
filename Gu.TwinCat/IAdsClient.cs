namespace Gu.TwinCat
{
    using System.ComponentModel;

    /// <summary>ADS Client / ADS Communication object.</summary>
    public interface IAdsClient : INotifyPropertyChanged
    {
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
    }
}
