namespace Gu.TwinCat
{
    using System;
    using TwinCAT.Ads;

    /// <summary>
    /// A symbol for reading from the PLC.
    /// </summary>
    /// <typeparam name="TPlc">The PLC type.</typeparam>
    /// <typeparam name="TCsharp">The c# type.</typeparam>
    public readonly struct ReadFromAdsSymbol<TPlc, TCsharp> : IEquatable<ReadFromAdsSymbol<TPlc, TCsharp>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadFromAdsSymbol{TPlc, TCsharp}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="read">Example (reader, _) => reader.ReadUint32().</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        public ReadFromAdsSymbol(string name, Func<TPlc, TCsharp> map, Func<AdsBinaryReader, int, TPlc> read, bool isActive = true)
        {
            this.Name = name;
            this.Map = map;
            this.Read = read;
            this.IsActive = isActive;
        }

        /// <summary>
        /// The symbol name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The mapping ex x => Length.FromMillimetres(x).
        /// </summary>
        public Func<TPlc, TCsharp> Map { get; }

        /// <summary>
        /// Example (reader, _) => reader.ReadUint32().
        /// </summary>
        public Func<AdsBinaryReader, int, TPlc> Read { get; }

        /// <summary>
        /// Specifies if the symbol is currently active.
        /// When not active the value is not read from PLC.
        /// Used for versioning.
        /// </summary>
        public bool IsActive { get; }

        /// <summary>Check if <paramref name="left"/> is equal to <paramref name="right"/>.</summary>
        /// <param name="left">The left <see cref="ReadFromAdsSymbol{TPlc, TCsharp}"/>.</param>
        /// <param name="right">The right <see cref="ReadFromAdsSymbol{TPlc, TCsharp}"/>.</param>
        /// <returns>True if <paramref name="left"/> is equal to <paramref name="right"/>.</returns>
        public static bool operator ==(ReadFromAdsSymbol<TPlc, TCsharp> left, ReadFromAdsSymbol<TPlc, TCsharp> right)
        {
            return left.Equals(right);
        }

        /// <summary>Check if <paramref name="left"/> is not equal to <paramref name="right"/>.</summary>
        /// <param name="left">The left <see cref="ReadFromAdsSymbol{TPlc, TCsharp}"/>.</param>
        /// <param name="right">The right <see cref="ReadFromAdsSymbol{TPlc, TCsharp}"/>.</param>
        /// <returns>True if <paramref name="left"/> is not equal to <paramref name="right"/>.</returns>
        public static bool operator !=(ReadFromAdsSymbol<TPlc, TCsharp> left, ReadFromAdsSymbol<TPlc, TCsharp> right)
        {
            return !left.Equals(right);
        }

        /// <inheritdoc />
        public bool Equals(ReadFromAdsSymbol<TPlc, TCsharp> other)
        {
            return this.Name == other.Name;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return obj is ReadFromAdsSymbol<TPlc, TCsharp> other && this.Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
    }
}
