namespace Gu.TwinCat
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// For representing presence or absence of a value.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    public struct Maybe<T> : IEquatable<Maybe<T>>
    {
        private readonly T value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Maybe{T}"/> struct.
        /// </summary>
        /// <param name="value">The value or default.</param>
        public Maybe(T value)
        {
            this.value = value;
            this.HasValue = true;
        }

        /// <summary>Gets the value if it has been assigned a valid underlying value. Or throws if The <see cref="HasValue" /> property is <see langword="false" />.</summary>
        /// <returns>The value.</returns>
        /// <exception cref="InvalidOperationException">The <see cref="HasValue" /> property is <see langword="false" />.</exception>
        public T Value
        {
            get
            {
                if (this.HasValue)
                {
                    return this.value;
                }

                throw new InvalidOperationException("Missing value.");
            }
        }

        /// <summary>
        /// If there is a value.
        /// </summary>
        public bool HasValue { get; }

        /// <summary>Check if <paramref name="left"/> is equal to <paramref name="right"/>.</summary>
        /// <param name="left">The left <see cref="Maybe{T}"/>.</param>
        /// <param name="right">The right <see cref="Maybe{T}"/>.</param>
        /// <returns>True if <paramref name="left"/> is equal to <paramref name="right"/>.</returns>
        public static bool operator ==(Maybe<T> left, Maybe<T> right)
        {
            return left.Equals(right);
        }

        /// <summary>Check if <paramref name="left"/> is not equal to <paramref name="right"/>.</summary>
        /// <param name="left">The left <see cref="Maybe{T}"/>.</param>
        /// <param name="right">The right <see cref="Maybe{T}"/>.</param>
        /// <returns>True if <paramref name="left"/> is not equal to <paramref name="right"/>.</returns>
        public static bool operator !=(Maybe<T> left, Maybe<T> right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Get the value or default.
        /// </summary>
        /// <returns>The value or default.</returns>
        public T? GetValueOrDefault() => this.HasValue ? this.value : default;

        /// <inheritdoc />
        public bool Equals(Maybe<T> other)
        {
            return EqualityComparer<T>.Default.Equals(this.value, other.value) && this.HasValue == other.HasValue;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return obj is Maybe<T> other && this.Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return (EqualityComparer<T>.Default.GetHashCode(this.value) * 397) ^ this.HasValue.GetHashCode();
            }
        }
    }
}
