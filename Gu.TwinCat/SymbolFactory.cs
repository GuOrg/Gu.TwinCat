﻿namespace Gu.TwinCat
{
    using System;

    /// <summary>
    /// Factory methods for <see cref="ReadFromAdsSymbol{TPlc,TCsharp}"/> and <see cref="WriteToAdsSymbol{TCsharp,TPlc}"/>.
    /// </summary>
    public static partial class SymbolFactory
    {
        /// <summary>
        /// The start of the address space. Can be used for health check.
        /// PLC1.Global_Variables.ADSSTATE_START.
        /// </summary>
        public static ReadFromAdsSymbol<uint, uint> AdsStateStart { get; } = new ReadFromAdsSymbol<uint, uint>("PLC1.Global_Variables.ADSSTATE_START", x => x);

        /// <summary>
        /// Creates a new instance of the <see cref="ReadFromAdsSymbol{T, T}"/> struct.
        /// </summary>
        /// <typeparam name="TPlc">The struct type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="ReadFromAdsSymbol{T, T}"/> struct.</returns>
        public static ReadFromAdsSymbol<TPlc, TPlc> ReadStruct<TPlc>(string name, bool isActive = true)
            where TPlc : struct
        {
            return new ReadFromAdsSymbol<TPlc, TPlc>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ReadFromAdsSymbol{T, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TPlc">The PLC type.</typeparam>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="ReadFromAdsSymbol{T, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<TPlc, TCsharp> ReadStruct<TPlc, TCsharp>(string name, Func<TPlc, TCsharp> map, bool isActive = true)
            where TPlc : struct
        {
            return new ReadFromAdsSymbol<TPlc, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="WriteToAdsSymbol{TPlc, TPlc}"/> struct.
        /// </summary>
        /// <typeparam name="TPlc">The struct type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="WriteToAdsSymbol{TPlc, TPlc}"/> struct.</returns>
        public static WriteToAdsSymbol<TPlc, TPlc> WriteStruct<TPlc>(string name, bool isActive = true)
            where TPlc : struct
        {
            return new WriteToAdsSymbol<TPlc, TPlc>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="WriteToAdsSymbol{TPlc,TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TPlc">The PLC type.</typeparam>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.Millimetres.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="WriteToAdsSymbol{TPlc, TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<TPlc, TCsharp> WriteStruct<TPlc, TCsharp>(string name, Func<TCsharp, TPlc> map, bool isActive = true)
            where TPlc : struct
        {
            return new WriteToAdsSymbol<TPlc, TCsharp>(name, map, isActive);
        }
    }
}
