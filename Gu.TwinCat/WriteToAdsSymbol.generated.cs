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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Boolean}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.Millimetres.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Boolean}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, Boolean> Boolean<TCsharp>(string name, Func<TCsharp, Boolean> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,Boolean>(name, map, isActive);
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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Boolean[]}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.ToArray().</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Boolean[]}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, Boolean[]> BooleanArray<TCsharp>(string name, Func<TCsharp, Boolean[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, Boolean[]>(name, map, isActive);
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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Byte}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.Millimetres.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Byte}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, Byte> Byte<TCsharp>(string name, Func<TCsharp, Byte> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,Byte>(name, map, isActive);
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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Byte[]}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.ToArray().</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Byte[]}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, Byte[]> ByteArray<TCsharp>(string name, Func<TCsharp, Byte[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, Byte[]>(name, map, isActive);
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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Char}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.Millimetres.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Char}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, Char> Char<TCsharp>(string name, Func<TCsharp, Char> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,Char>(name, map, isActive);
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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Char[]}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.ToArray().</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Char[]}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, Char[]> CharArray<TCsharp>(string name, Func<TCsharp, Char[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, Char[]>(name, map, isActive);
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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Double}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.Millimetres.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Double}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, Double> Double<TCsharp>(string name, Func<TCsharp, Double> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,Double>(name, map, isActive);
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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Double[]}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.ToArray().</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Double[]}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, Double[]> DoubleArray<TCsharp>(string name, Func<TCsharp, Double[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, Double[]>(name, map, isActive);
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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Int16}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.Millimetres.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Int16}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, Int16> Int16<TCsharp>(string name, Func<TCsharp, Int16> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,Int16>(name, map, isActive);
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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Int16[]}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.ToArray().</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Int16[]}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, Int16[]> Int16Array<TCsharp>(string name, Func<TCsharp, Int16[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, Int16[]>(name, map, isActive);
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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Int32}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.Millimetres.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Int32}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, Int32> Int32<TCsharp>(string name, Func<TCsharp, Int32> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,Int32>(name, map, isActive);
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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Int32[]}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.ToArray().</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Int32[]}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, Int32[]> Int32Array<TCsharp>(string name, Func<TCsharp, Int32[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, Int32[]>(name, map, isActive);
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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Int64}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.Millimetres.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Int64}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, Int64> Int64<TCsharp>(string name, Func<TCsharp, Int64> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,Int64>(name, map, isActive);
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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Int64[]}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.ToArray().</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Int64[]}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, Int64[]> Int64Array<TCsharp>(string name, Func<TCsharp, Int64[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, Int64[]>(name, map, isActive);
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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, SByte}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.Millimetres.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, SByte}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, SByte> SByte<TCsharp>(string name, Func<TCsharp, SByte> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,SByte>(name, map, isActive);
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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, SByte[]}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.ToArray().</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, SByte[]}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, SByte[]> SByteArray<TCsharp>(string name, Func<TCsharp, SByte[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, SByte[]>(name, map, isActive);
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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Single}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.Millimetres.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Single}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, Single> Single<TCsharp>(string name, Func<TCsharp, Single> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,Single>(name, map, isActive);
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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Single[]}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.ToArray().</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, Single[]}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, Single[]> SingleArray<TCsharp>(string name, Func<TCsharp, Single[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, Single[]>(name, map, isActive);
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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, UInt16}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.Millimetres.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, UInt16}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, UInt16> UInt16<TCsharp>(string name, Func<TCsharp, UInt16> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,UInt16>(name, map, isActive);
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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, UInt16[]}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.ToArray().</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, UInt16[]}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, UInt16[]> UInt16Array<TCsharp>(string name, Func<TCsharp, UInt16[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, UInt16[]>(name, map, isActive);
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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, UInt32}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.Millimetres.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, UInt32}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, UInt32> UInt32<TCsharp>(string name, Func<TCsharp, UInt32> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,UInt32>(name, map, isActive);
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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, UInt32[]}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.ToArray().</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, UInt32[]}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, UInt32[]> UInt32Array<TCsharp>(string name, Func<TCsharp, UInt32[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, UInt32[]>(name, map, isActive);
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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, UInt64}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.Millimetres.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, UInt64}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, UInt64> UInt64<TCsharp>(string name, Func<TCsharp, UInt64> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,UInt64>(name, map, isActive);
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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, UInt64[]}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.ToArray().</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, UInt64[]}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, UInt64[]> UInt64Array<TCsharp>(string name, Func<TCsharp, UInt64[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, UInt64[]>(name, map, isActive);
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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, String}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.Millimetres.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, String}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, String> String<TCsharp>(string name, Func<TCsharp, String> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,String>(name, map, isActive);
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
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, String[]}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => x.ToArray().</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{TCsharp, String[]}"/> struct.</returns>
        public static WriteToAdsSymbol<TCsharp, String[]> StringArray<TCsharp>(string name, Func<TCsharp, String[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, String[]>(name, map, isActive);
        }

    }
}