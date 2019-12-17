namespace Gu.TwinCat
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using TwinCAT.Ads;

    /// <summary>ADS Client / ADS Communication object.</summary>
    public class AdsClient : TcAdsClient, IAdsClient
    {
        /// <inheritdoc />
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>Establishes a connection to a ADS device.</summary>
        /// <param name="netId">NetId of the ADS server.</param>
        /// <param name="srvPort">Port number of the ADS server.</param>
        public new void Connect(string netId, int srvPort)
        {
            if (netId is null)
            {
                throw new System.ArgumentNullException(nameof(netId));
            }

            base.Connect(netId, srvPort);
            this.OnPropertyChanged(nameof(this.ClientAddress));
            this.OnPropertyChanged(nameof(this.IsConnected));
        }

        /// <summary>
        /// Reads the value of a symbol and returns the value as object. The parameter type must have the same
        /// layout as the ADS symbol.
        /// </summary>
        /// <typeparam name="TPlc">The PLC type.</typeparam>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="symbol">The <see cref="ReadFromAdsSymbol{TPlc,TCsharp}"/>.</param>
        /// <returns>Value of the symbol.</returns>
        public TCsharp Read<TPlc, TCsharp>(ReadFromAdsSymbol<TPlc, TCsharp> symbol)
        {
            if (symbol.IsActive)
            {
                return symbol.Map((TPlc)this.ReadSymbol(symbol.Name, typeof(TPlc), reloadSymbolInfo: false));
            }

            return symbol.Map(default!);
        }

        /// <summary>
        /// Reads the value of a symbol and returns the value as object. The parameter type must have the same
        /// layout as the ADS symbol.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <typeparam name="TPlc">The PLC type.</typeparam>
        /// <param name="symbol">The <see cref="WriteToAdsSymbol{TCsharp,TPlc}"/>.</param>
        /// <param name="value">The value.</param>
        public void Write<TCsharp, TPlc>(WriteToAdsSymbol<TCsharp, TPlc> symbol, TCsharp value)
        {
            if (symbol.IsActive)
            {
                this.WriteSymbol(symbol.Name, symbol.Map(value), reloadSymbolInfo: false);
            }
        }

        /// <summary>
        /// Invoke <see cref="PropertyChanged"/>.
        /// </summary>
        /// <param name="propertyName">The property name.</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
