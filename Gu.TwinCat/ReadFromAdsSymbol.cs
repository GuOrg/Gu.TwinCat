namespace Gu.TwinCat
{
    /// <summary>
    /// Factory methods for <see cref="ReadFromAdsSymbol{TPlc,TCsharp}"/>.
    /// </summary>
    public static class ReadFromAdsSymbol
    {
        /// <summary>
        /// The start of the address space. Can be used for health check.
        /// </summary>
        public static ReadFromAdsSymbol<uint, uint> AdsStateStart { get; } = new ReadFromAdsSymbol<uint, uint>("PLC1.Global_Variables.ADSSTATE_START", x => x);
    }
}
