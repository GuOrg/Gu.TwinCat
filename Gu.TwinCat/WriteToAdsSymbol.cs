namespace Gu.TwinCat
{
    using System;

    /// <summary>
    /// Factory methods for <see cref="WriteToAdsSymbol{TPlc,TCsharp}"/>.
    /// </summary>
    public static partial class WriteToAdsSymbol
    {
        /// <summary>
        /// Creates a new instance of the <see cref="WriteToAdsSymbol{TPlc, TPlc}"/> struct.
        /// </summary>
        /// <typeparam name="TPlc">The struct type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="WriteToAdsSymbol{TPlc, TPlc}"/> struct.</returns>
        public static WriteToAdsSymbol<TPlc, TPlc> Struct<TPlc>(string name, bool isActive = true)
            where TPlc : struct
        {
            return new WriteToAdsSymbol<TPlc, TPlc>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="WriteToAdsSymbol{TCsharp, TPlc}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <typeparam name="TPlc">The PLC type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.Millimetres.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="WriteToAdsSymbol{TCsharp, TPlc}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, TPlc> Struct<TCsharp, TPlc>(string name, Func<TCsharp, TPlc> map, bool isActive = true)
            where TPlc : struct
        {
            return new WriteToAdsSymbol<TCsharp, TPlc>(name, map, isActive);
        }
    }
}
