namespace Gu.TwinCat
{
    using System;

    /// <summary>
    /// A symbol for writing to the PLC.
    /// </summary>
    /// <typeparam name="TPlc">The PLC type.</typeparam>
    /// <typeparam name="TCsharp">The c# type.</typeparam>
    public readonly struct WriteToAdsSymbol<TPlc, TCsharp> : IEquatable<WriteToAdsSymbol<TPlc, TCsharp>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WriteToAdsSymbol{TCsharp, TPlc}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.Millimetres.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        public WriteToAdsSymbol(string name, Func<TCsharp, TPlc> map, bool isActive)
        {
            this.Name = name;
            this.Map = map;
            this.IsActive = isActive;
        }

        /// <summary>
        /// The symbol name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The mapping ex x => x.Millimetres.
        /// </summary>
        public Func<TCsharp, TPlc> Map { get; }

        /// <summary>
        /// Specifies if the symbol is currently active.
        /// When not active the value is not read from PLC.
        /// Used for versioning.
        /// </summary>
        public bool IsActive { get; }

        /// <summary>Check if <paramref name="left"/> is equal to <paramref name="right"/>.</summary>
        /// <param name="left">The left <see cref="WriteToAdsSymbol{TPlc,TCsharp}"/>.</param>
        /// <param name="right">The right <see cref="WriteToAdsSymbol{TPlc,TCsharp}"/>.</param>
        /// <returns>True if <paramref name="left"/> is equal to <paramref name="right"/>.</returns>
        public static bool operator ==(WriteToAdsSymbol<TPlc, TCsharp> left, WriteToAdsSymbol<TPlc, TCsharp> right)
        {
            return left.Equals(right);
        }

        /// <summary>Check if <paramref name="left"/> is not equal to <paramref name="right"/>.</summary>
        /// <param name="left">The left <see cref="WriteToAdsSymbol{TPlc,TCsharp}"/>.</param>
        /// <param name="right">The right <see cref="WriteToAdsSymbol{TPlc,TCsharp}"/>.</param>
        /// <returns>True if <paramref name="left"/> is not equal to <paramref name="right"/>.</returns>
        public static bool operator !=(WriteToAdsSymbol<TPlc, TCsharp> left, WriteToAdsSymbol<TPlc, TCsharp> right)
        {
            return !left.Equals(right);
        }

        /// <inheritdoc />
        public bool Equals(WriteToAdsSymbol<TPlc, TCsharp> other)
        {
            return this.Name == other.Name;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return obj is WriteToAdsSymbol<TPlc, TCsharp> other && this.Equals(other);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
    }
}
