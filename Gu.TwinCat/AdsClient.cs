namespace Gu.TwinCat
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using TwinCAT.Ads;

    /// <summary>ADS Client / ADS Communication object.</summary>
    public class AdsClient : TcAdsClient, IAdsClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdsClient"/> class.
        /// </summary>
        public AdsClient()
        {
            this.ConnectionStateChanged += (_, __) =>
            {
                this.OnPropertyChanged(nameof(this.ClientAddress));
                this.OnPropertyChanged(nameof(this.IsConnected));
                this.OnPropertyChanged(nameof(this.ConnectionState));
            };
        }

        /// <inheritdoc />
        public event PropertyChangedEventHandler? PropertyChanged;

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
