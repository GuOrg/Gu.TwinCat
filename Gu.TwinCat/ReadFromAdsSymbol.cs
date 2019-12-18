namespace Gu.TwinCat
{
    /// <summary>
    /// Factory methods for <see cref="ReadFromAdsSymbol{TPlc,TCsharp}"/>.
    /// </summary>
    public static partial class ReadFromAdsSymbol
    {
        /// <summary>
        /// The start of the address space. Can be used for health check.
        /// </summary>
        public static ReadFromAdsSymbol<uint, uint> AdsStateStart { get; } = new ReadFromAdsSymbol<uint, uint>("PLC1.Global_Variables.ADSSTATE_START", x => x, (reader, _) => reader.ReadUInt32());

        ///// <summary>
        ///// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{<#= type #>, <#= type #>}"/> struct.
        ///// </summary>
        ///// <param name="name">The symbol name.</param>
        ///// <param name="isActive">Specifies if the symbol is currently active.</param>
        ///// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{<#= type #>, <#= type #>}"/> struct.</returns>
        //public static ReadFromAdsSymbol<<#= type #>[], <#= type #>[]> <#= type #>Array(string name, bool isActive = true)
        //{
        //    return new ReadFromAdsSymbol<<#= type #>[], <#= type #>[]>(name, x => x, isActive);
        //}

        ///// <summary>
        ///// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{<#= type #>[], TCsharp}"/> struct.
        ///// </summary>
        ///// <typeparam name="TCsharp">The c# type.</typeparam>
        ///// <param name="name">The symbol name.</param>
        ///// <param name="map">The mapping ex x => ImmutableArray.Create(x).</param>
        ///// <param name="isActive">Specifies if the symbol is currently active.</param>
        ///// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{<#= type #>[], TCsharp}"/> struct.</returns>
        //public static ReadFromAdsSymbol<<#= type #>[], TCsharp> <#= type #>Array<TCsharp>(string name, Func<<#= type #>[], TCsharp> map, bool isActive = true)
        //{
        //    return new ReadFromAdsSymbol<<#= type #>[], TCsharp>(name, map, isActive);
        //}
    }
}
