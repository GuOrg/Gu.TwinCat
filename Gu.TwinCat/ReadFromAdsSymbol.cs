namespace Gu.TwinCat
{
    using System;

    /// <summary>
    /// Factory methods for <see cref="ReadFromAdsSymbol{TPlc,TCsharp}"/>.
    /// </summary>
    public static partial class ReadFromAdsSymbol
    {
        /// <summary>
        /// The start of the address space. Can be used for health check.
        /// PLC1.Global_Variables.ADSSTATE_START.
        /// </summary>
        public static ReadFromAdsSymbol<uint, uint> AdsStateStart { get; } = new ReadFromAdsSymbol<uint, uint>("PLC1.Global_Variables.ADSSTATE_START", x => x);

        /// <summary>
        /// Creates a new instance of the <see cref="ReadFromAdsSymbol{T, T}"/> struct.
        /// </summary>
        /// <typeparam name="T">The struct type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="ReadFromAdsSymbol{T, T}"/> struct.</returns>
        public static ReadFromAdsSymbol<T, T> Struct<T>(string name, bool isActive = true)
            where T : struct
        {
            return new ReadFromAdsSymbol<T, T>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ReadFromAdsSymbol{T, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="T">The struct type.</typeparam>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="ReadFromAdsSymbol{T, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<T, TCsharp> Boolean<T, TCsharp>(string name, Func<T, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<T, TCsharp>(name, map, isActive);
        }
    }
}
