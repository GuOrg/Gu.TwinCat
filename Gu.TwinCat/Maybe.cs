namespace Gu.TwinCat
{
    /// <summary>
    /// Factory methods for <see cref="Maybe{T}"/>.
    /// </summary>
    public static class Maybe
    {
        /// <summary>
        /// Creates an instance of <see cref="Maybe{T}"/> with no value.
        /// </summary>
        /// <typeparam name="T">The type a value would have had.</typeparam>
        /// <returns>default(<see cref="Maybe{T}"/>).</returns>
        public static Maybe<T> None<T>() => default;

        /// <summary>
        /// Creates an instance of <see cref="Maybe{T}"/> with no value.
        /// </summary>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <param name="value">The value.</param>
        /// <returns>An instance of <see cref="Maybe{T}"/> with no value.</returns>
        public static Maybe<T> Some<T>(T value) => new Maybe<T>(value);
    }
}
