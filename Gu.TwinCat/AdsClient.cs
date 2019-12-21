namespace Gu.TwinCat
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using TwinCAT;
    using TwinCAT.Ads;

    /// <summary>ADS Client / ADS Communication object.</summary>
    public class AdsClient : TcAdsClient, IAdsClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdsClient"/> class.
        /// </summary>
        /// <param name="inactiveSymbolHandling">The <see cref="TwinCat.InactiveSymbolHandling"/>.</param>
        public AdsClient(InactiveSymbolHandling inactiveSymbolHandling = InactiveSymbolHandling.Throw)
        {
            if (!Enum.IsDefined(typeof(InactiveSymbolHandling), inactiveSymbolHandling))
            {
                throw new InvalidEnumArgumentException(nameof(inactiveSymbolHandling), (int)inactiveSymbolHandling, typeof(InactiveSymbolHandling));
            }

            this.InactiveSymbolHandling = inactiveSymbolHandling;

            this.AmsRouterNotification += (_, e) =>
            {
                this.OnPropertyChanged(nameof(this.RouterState));
                this.OnPropertyChanged(nameof(this.AdsState));
            };

            this.AdsStateChanged += (_, e) =>
            {
                this.OnPropertyChanged(nameof(this.AdsState));
            };
        }

        /// <inheritdoc />
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Specifies how this instance handles inactive symbols.
        /// </summary>
        public InactiveSymbolHandling InactiveSymbolHandling { get; }

        /// <summary>
        /// The current <see cref="AdsState"/>.
        /// </summary>
        public AdsState AdsState => this.IsConnected && this.TryReadState(out var state) == AdsErrorCode.NoError
            ? state.AdsState
            : AdsState.Invalid;

        /// <summary>
        /// Reads the value of a symbol and returns the value.
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

            return this.InactiveSymbolHandling switch
            {
                InactiveSymbolHandling.Throw => throw new InvalidOperationException("Reading inactive symbol is not allowed."),
                InactiveSymbolHandling.UseDefault => symbol.Map(default!),
                _ => throw new InvalidEnumArgumentException(nameof(AdsClient), (int)this.InactiveSymbolHandling, typeof(InactiveSymbolHandling)),
            };
        }

        /// <summary>
        /// Writes the value of a symbol.
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
            else
            {
                switch (this.InactiveSymbolHandling)
                {
                    case InactiveSymbolHandling.Throw:
                        throw new InvalidOperationException("Writing inactive symbol is not allowed.");
                    case InactiveSymbolHandling.UseDefault:
                        break;
                    default:
                        throw new InvalidEnumArgumentException(nameof(AdsClient), (int)this.InactiveSymbolHandling, typeof(InactiveSymbolHandling));
                }
            }
        }

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
        public Subscription<TPlc, TCsharp> Subscribe<TPlc, TCsharp>(ReadFromAdsSymbol<TPlc, TCsharp> symbol, AdsTransMode transMode, AdsTimeSpan cycleTime, AdsTimeSpan maxDelay = default)
        {
            return new Subscription<TPlc, TCsharp>(this, symbol, transMode, cycleTime, maxDelay);
        }

        /// <inheritdoc/>
        protected override void OnConnectionStateChanged(TwinCAT.ConnectionState newState, TwinCAT.ConnectionState oldState)
        {
            base.OnConnectionStateChanged(newState, oldState);
            this.OnPropertyChanged(nameof(this.ClientAddress));
            this.OnPropertyChanged(nameof(this.ClientCycle));
            this.OnPropertyChanged(nameof(this.IsConnected));
            this.OnPropertyChanged(nameof(this.ConnectionState));
            this.OnPropertyChanged(nameof(this.Id));
            this.OnPropertyChanged(nameof(this.AdsState));
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
