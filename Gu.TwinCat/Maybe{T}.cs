namespace Gu.TwinCat
{
    using System;

    /// <summary>
    /// For representing presence or absence of a value.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    public struct Maybe<T>
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

        /// <summary>
        /// Get the value or default.
        /// </summary>
        /// <returns>The value or default.</returns>
        public T GetValueOrDefault() => this.HasValue ? this.value : default;
    }
}
