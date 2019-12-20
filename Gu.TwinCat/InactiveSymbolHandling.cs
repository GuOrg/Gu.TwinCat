namespace Gu.TwinCat
{
    /// <summary>
    /// Specifies how inactive symbols are handled by <see cref="AdsClient"/>.
    /// </summary>
    public enum InactiveSymbolHandling
    {
        /// <summary>
        /// Throw if trying to read or write an inactive symbol.
        /// </summary>
        Throw,

        /// <summary>
        /// Return default value when reading an inactive symbol.
        /// </summary>
        UseDefault,
    }
}
