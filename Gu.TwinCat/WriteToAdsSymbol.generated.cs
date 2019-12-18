namespace Gu.TwinCat
{
    using System;

    /// <summary>
    /// Factory methods for <see cref="WriteToAdsSymbol{TPlc,TCsharp}"/>.
    /// </summary>
    public static partial class WriteToAdsSymbol
    {
        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Boolean, Boolean}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Boolean, Boolean}"/> struct.</returns>
        public static WriteToAdsSymbol<Boolean, Boolean> Boolean(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<Boolean, Boolean>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Boolean, Boolean}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Boolean, Boolean}"/> struct.</returns>
        public static WriteToAdsSymbol<Boolean[], Boolean[]> BooleanArray(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<Boolean[], Boolean[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Boolean, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Boolean, TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<Boolean, TCsharp> Create<TCsharp>(string name, Func<Boolean, TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<Boolean, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Boolean[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Boolean[], TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<Boolean[], TCsharp> Create<TCsharp>(string name, Func<Boolean[], TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<Boolean[], TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Byte, Byte}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Byte, Byte}"/> struct.</returns>
        public static WriteToAdsSymbol<Byte, Byte> Byte(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<Byte, Byte>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Byte, Byte}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Byte, Byte}"/> struct.</returns>
        public static WriteToAdsSymbol<Byte[], Byte[]> ByteArray(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<Byte[], Byte[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Byte, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Byte, TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<Byte, TCsharp> Create<TCsharp>(string name, Func<Byte, TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<Byte, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Byte[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Byte[], TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<Byte[], TCsharp> Create<TCsharp>(string name, Func<Byte[], TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<Byte[], TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Char, Char}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Char, Char}"/> struct.</returns>
        public static WriteToAdsSymbol<Char, Char> Char(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<Char, Char>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Char, Char}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Char, Char}"/> struct.</returns>
        public static WriteToAdsSymbol<Char[], Char[]> CharArray(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<Char[], Char[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Char, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Char, TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<Char, TCsharp> Create<TCsharp>(string name, Func<Char, TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<Char, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Char[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Char[], TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<Char[], TCsharp> Create<TCsharp>(string name, Func<Char[], TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<Char[], TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Double, Double}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Double, Double}"/> struct.</returns>
        public static WriteToAdsSymbol<Double, Double> Double(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<Double, Double>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Double, Double}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Double, Double}"/> struct.</returns>
        public static WriteToAdsSymbol<Double[], Double[]> DoubleArray(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<Double[], Double[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Double, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Double, TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<Double, TCsharp> Create<TCsharp>(string name, Func<Double, TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<Double, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Double[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Double[], TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<Double[], TCsharp> Create<TCsharp>(string name, Func<Double[], TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<Double[], TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Int16, Int16}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Int16, Int16}"/> struct.</returns>
        public static WriteToAdsSymbol<Int16, Int16> Int16(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<Int16, Int16>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Int16, Int16}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Int16, Int16}"/> struct.</returns>
        public static WriteToAdsSymbol<Int16[], Int16[]> Int16Array(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<Int16[], Int16[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Int16, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Int16, TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<Int16, TCsharp> Create<TCsharp>(string name, Func<Int16, TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<Int16, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Int16[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Int16[], TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<Int16[], TCsharp> Create<TCsharp>(string name, Func<Int16[], TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<Int16[], TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Int32, Int32}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Int32, Int32}"/> struct.</returns>
        public static WriteToAdsSymbol<Int32, Int32> Int32(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<Int32, Int32>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Int32, Int32}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Int32, Int32}"/> struct.</returns>
        public static WriteToAdsSymbol<Int32[], Int32[]> Int32Array(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<Int32[], Int32[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Int32, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Int32, TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<Int32, TCsharp> Create<TCsharp>(string name, Func<Int32, TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<Int32, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Int32[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Int32[], TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<Int32[], TCsharp> Create<TCsharp>(string name, Func<Int32[], TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<Int32[], TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Int64, Int64}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Int64, Int64}"/> struct.</returns>
        public static WriteToAdsSymbol<Int64, Int64> Int64(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<Int64, Int64>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Int64, Int64}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Int64, Int64}"/> struct.</returns>
        public static WriteToAdsSymbol<Int64[], Int64[]> Int64Array(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<Int64[], Int64[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Int64, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Int64, TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<Int64, TCsharp> Create<TCsharp>(string name, Func<Int64, TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<Int64, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Int64[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Int64[], TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<Int64[], TCsharp> Create<TCsharp>(string name, Func<Int64[], TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<Int64[], TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{SByte, SByte}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{SByte, SByte}"/> struct.</returns>
        public static WriteToAdsSymbol<SByte, SByte> SByte(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<SByte, SByte>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{SByte, SByte}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{SByte, SByte}"/> struct.</returns>
        public static WriteToAdsSymbol<SByte[], SByte[]> SByteArray(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<SByte[], SByte[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{SByte, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{SByte, TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<SByte, TCsharp> Create<TCsharp>(string name, Func<SByte, TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<SByte, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{SByte[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{SByte[], TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<SByte[], TCsharp> Create<TCsharp>(string name, Func<SByte[], TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<SByte[], TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Single, Single}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Single, Single}"/> struct.</returns>
        public static WriteToAdsSymbol<Single, Single> Single(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<Single, Single>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Single, Single}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Single, Single}"/> struct.</returns>
        public static WriteToAdsSymbol<Single[], Single[]> SingleArray(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<Single[], Single[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Single, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Single, TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<Single, TCsharp> Create<TCsharp>(string name, Func<Single, TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<Single, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Single[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Single[], TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<Single[], TCsharp> Create<TCsharp>(string name, Func<Single[], TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<Single[], TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{UInt16, UInt16}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{UInt16, UInt16}"/> struct.</returns>
        public static WriteToAdsSymbol<UInt16, UInt16> UInt16(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<UInt16, UInt16>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{UInt16, UInt16}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{UInt16, UInt16}"/> struct.</returns>
        public static WriteToAdsSymbol<UInt16[], UInt16[]> UInt16Array(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<UInt16[], UInt16[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{UInt16, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{UInt16, TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<UInt16, TCsharp> Create<TCsharp>(string name, Func<UInt16, TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<UInt16, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{UInt16[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{UInt16[], TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<UInt16[], TCsharp> Create<TCsharp>(string name, Func<UInt16[], TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<UInt16[], TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{UInt32, UInt32}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{UInt32, UInt32}"/> struct.</returns>
        public static WriteToAdsSymbol<UInt32, UInt32> UInt32(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<UInt32, UInt32>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{UInt32, UInt32}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{UInt32, UInt32}"/> struct.</returns>
        public static WriteToAdsSymbol<UInt32[], UInt32[]> UInt32Array(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<UInt32[], UInt32[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{UInt32, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{UInt32, TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<UInt32, TCsharp> Create<TCsharp>(string name, Func<UInt32, TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<UInt32, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{UInt32[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{UInt32[], TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<UInt32[], TCsharp> Create<TCsharp>(string name, Func<UInt32[], TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<UInt32[], TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{UInt64, UInt64}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{UInt64, UInt64}"/> struct.</returns>
        public static WriteToAdsSymbol<UInt64, UInt64> UInt64(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<UInt64, UInt64>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{UInt64, UInt64}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{UInt64, UInt64}"/> struct.</returns>
        public static WriteToAdsSymbol<UInt64[], UInt64[]> UInt64Array(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<UInt64[], UInt64[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{UInt64, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{UInt64, TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<UInt64, TCsharp> Create<TCsharp>(string name, Func<UInt64, TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<UInt64, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{UInt64[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{UInt64[], TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<UInt64[], TCsharp> Create<TCsharp>(string name, Func<UInt64[], TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<UInt64[], TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{String, String}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{String, String}"/> struct.</returns>
        public static WriteToAdsSymbol<String, String> String(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<String, String>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{String, String}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{String, String}"/> struct.</returns>
        public static WriteToAdsSymbol<String[], String[]> StringArray(string name, bool isActive = true)
        {
            return new WriteToAdsSymbol<String[], String[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{String, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{String, TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<String, TCsharp> Create<TCsharp>(string name, Func<String, TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<String, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{String[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{String[], TCsharp}"/> struct.</returns>
        public static WriteToAdsSymbol<String[], TCsharp> Create<TCsharp>(string name, Func<String[], TCsharp> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<String[], TCsharp>(name, map, isActive);
        }

    }
}