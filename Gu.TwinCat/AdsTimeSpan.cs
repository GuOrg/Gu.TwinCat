namespace Gu.TwinCat
{
    using System;

    /// <summary>
    /// A <see cref="TimeSpan"/> for ADS.
    /// </summary>
    public struct AdsTimeSpan : IEquatable<AdsTimeSpan>
    {
        /// <summary>
        /// The time in milliseconds.
        /// </summary>
        public readonly int Milliseconds;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdsTimeSpan"/> struct.
        /// </summary>
        /// <param name="milliseconds">The time in milliseconds.</param>
        public AdsTimeSpan(int milliseconds)
        {
            this.Milliseconds = milliseconds;
        }

        /// <summary>Check if <paramref name="left"/> is equal to <paramref name="right"/>.</summary>
        /// <param name="left">The left <see cref="AdsTimeSpan"/>.</param>
        /// <param name="right">The right <see cref="AdsTimeSpan"/>.</param>
        /// <returns>True if <paramref name="left"/> is equal to <paramref name="right"/>.</returns>
        public static bool operator ==(AdsTimeSpan left, AdsTimeSpan right)
        {
            return left.Equals(right);
        }

        /// <summary>Check if <paramref name="left"/> is not equal to <paramref name="right"/>.</summary>
        /// <param name="left">The left <see cref="AdsTimeSpan"/>.</param>
        /// <param name="right">The right <see cref="AdsTimeSpan"/>.</param>
        /// <returns>True if <paramref name="left"/> is not equal to <paramref name="right"/>.</returns>
        public static bool operator !=(AdsTimeSpan left, AdsTimeSpan right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Create from milliseconds.
        /// </summary>
        /// <param name="milliseconds">The time in milliseconds.</param>
        /// <returns>A new instance of the <see cref="AdsTimeSpan"/> struct.</returns>
        public static AdsTimeSpan FromMilliseconds(int milliseconds) => new AdsTimeSpan(milliseconds);

        /// <summary>
        /// Create from seconds.
        /// </summary>
        /// <param name="seconds">The time in seconds.</param>
        /// <returns>A new instance of the <see cref="AdsTimeSpan"/> struct.</returns>
        public static AdsTimeSpan FromSeconds(int seconds) => new AdsTimeSpan(seconds * 1000);

        /// <summary>
        /// Create from minutes.
        /// </summary>
        /// <param name="minutes">The time in minutes.</param>
        /// <returns>A new instance of the <see cref="AdsTimeSpan"/> struct.</returns>
        public static AdsTimeSpan FromMinutes(int minutes) => new AdsTimeSpan(minutes * 60 * 1000);

        /// <inheritdoc />
        public bool Equals(AdsTimeSpan other)
        {
            return this.Milliseconds == other.Milliseconds;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return obj is AdsTimeSpan other && this.Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return this.Milliseconds;
        }

        /// <inheritdoc />
        public override string ToString() => $"{this.Milliseconds} ms";
    }
}
