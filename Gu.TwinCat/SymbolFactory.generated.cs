namespace Gu.TwinCat
{
    using System;

    /// <summary>
    /// Factory methods for <see cref="WriteToAdsSymbol{TPlc,TCsharp}"/>.
    /// </summary>
    public static partial class SymbolFactory
    {
        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Boolean, Boolean}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Boolean, Boolean}"/> struct.</returns>
        public static ReadFromAdsSymbol<Boolean, Boolean> ReadBoolean(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Boolean, Boolean>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Boolean, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Boolean, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<Boolean, TCsharp> ReadBoolean<TCsharp>(string name, Func<Boolean, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Boolean, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Boolean, Boolean}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Boolean, Boolean}"/> struct.</returns>
        public static ReadFromAdsSymbol<Boolean[], Boolean[]> ReadBooleanArray(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Boolean[], Boolean[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Boolean[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => ImmutableArray.Create(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Boolean[], TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<Boolean[], TCsharp> ReadBooleanArray<TCsharp>(string name, Func<Boolean[], TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Boolean[], TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Boolean, Boolean}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Boolean, Boolean}"/> struct.</returns>
        public static WriteToAdsSymbol<Boolean, Boolean> WriteBoolean(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, Boolean> WriteBoolean<TCsharp>(string name, Func<TCsharp, Boolean> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,Boolean>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Boolean, Boolean}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Boolean, Boolean}"/> struct.</returns>
        public static WriteToAdsSymbol<Boolean[], Boolean[]> WriteBooleanArray(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, Boolean[]> WriteBooleanArray<TCsharp>(string name, Func<TCsharp, Boolean[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, Boolean[]>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Byte, Byte}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Byte, Byte}"/> struct.</returns>
        public static ReadFromAdsSymbol<Byte, Byte> ReadByte(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Byte, Byte>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Byte, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Byte, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<Byte, TCsharp> ReadByte<TCsharp>(string name, Func<Byte, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Byte, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Byte, Byte}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Byte, Byte}"/> struct.</returns>
        public static ReadFromAdsSymbol<Byte[], Byte[]> ReadByteArray(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Byte[], Byte[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Byte[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => ImmutableArray.Create(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Byte[], TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<Byte[], TCsharp> ReadByteArray<TCsharp>(string name, Func<Byte[], TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Byte[], TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Byte, Byte}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Byte, Byte}"/> struct.</returns>
        public static WriteToAdsSymbol<Byte, Byte> WriteByte(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, Byte> WriteByte<TCsharp>(string name, Func<TCsharp, Byte> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,Byte>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Byte, Byte}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Byte, Byte}"/> struct.</returns>
        public static WriteToAdsSymbol<Byte[], Byte[]> WriteByteArray(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, Byte[]> WriteByteArray<TCsharp>(string name, Func<TCsharp, Byte[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, Byte[]>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Char, Char}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Char, Char}"/> struct.</returns>
        public static ReadFromAdsSymbol<Char, Char> ReadChar(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Char, Char>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Char, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Char, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<Char, TCsharp> ReadChar<TCsharp>(string name, Func<Char, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Char, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Char, Char}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Char, Char}"/> struct.</returns>
        public static ReadFromAdsSymbol<Char[], Char[]> ReadCharArray(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Char[], Char[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Char[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => ImmutableArray.Create(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Char[], TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<Char[], TCsharp> ReadCharArray<TCsharp>(string name, Func<Char[], TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Char[], TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Char, Char}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Char, Char}"/> struct.</returns>
        public static WriteToAdsSymbol<Char, Char> WriteChar(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, Char> WriteChar<TCsharp>(string name, Func<TCsharp, Char> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,Char>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Char, Char}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Char, Char}"/> struct.</returns>
        public static WriteToAdsSymbol<Char[], Char[]> WriteCharArray(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, Char[]> WriteCharArray<TCsharp>(string name, Func<TCsharp, Char[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, Char[]>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Double, Double}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Double, Double}"/> struct.</returns>
        public static ReadFromAdsSymbol<Double, Double> ReadDouble(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Double, Double>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Double, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Double, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<Double, TCsharp> ReadDouble<TCsharp>(string name, Func<Double, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Double, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Double, Double}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Double, Double}"/> struct.</returns>
        public static ReadFromAdsSymbol<Double[], Double[]> ReadDoubleArray(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Double[], Double[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Double[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => ImmutableArray.Create(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Double[], TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<Double[], TCsharp> ReadDoubleArray<TCsharp>(string name, Func<Double[], TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Double[], TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Double, Double}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Double, Double}"/> struct.</returns>
        public static WriteToAdsSymbol<Double, Double> WriteDouble(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, Double> WriteDouble<TCsharp>(string name, Func<TCsharp, Double> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,Double>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Double, Double}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Double, Double}"/> struct.</returns>
        public static WriteToAdsSymbol<Double[], Double[]> WriteDoubleArray(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, Double[]> WriteDoubleArray<TCsharp>(string name, Func<TCsharp, Double[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, Double[]>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Int16, Int16}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Int16, Int16}"/> struct.</returns>
        public static ReadFromAdsSymbol<Int16, Int16> ReadInt16(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Int16, Int16>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Int16, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Int16, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<Int16, TCsharp> ReadInt16<TCsharp>(string name, Func<Int16, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Int16, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Int16, Int16}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Int16, Int16}"/> struct.</returns>
        public static ReadFromAdsSymbol<Int16[], Int16[]> ReadInt16Array(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Int16[], Int16[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Int16[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => ImmutableArray.Create(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Int16[], TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<Int16[], TCsharp> ReadInt16Array<TCsharp>(string name, Func<Int16[], TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Int16[], TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Int16, Int16}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Int16, Int16}"/> struct.</returns>
        public static WriteToAdsSymbol<Int16, Int16> WriteInt16(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, Int16> WriteInt16<TCsharp>(string name, Func<TCsharp, Int16> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,Int16>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Int16, Int16}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Int16, Int16}"/> struct.</returns>
        public static WriteToAdsSymbol<Int16[], Int16[]> WriteInt16Array(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, Int16[]> WriteInt16Array<TCsharp>(string name, Func<TCsharp, Int16[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, Int16[]>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Int32, Int32}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Int32, Int32}"/> struct.</returns>
        public static ReadFromAdsSymbol<Int32, Int32> ReadInt32(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Int32, Int32>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Int32, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Int32, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<Int32, TCsharp> ReadInt32<TCsharp>(string name, Func<Int32, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Int32, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Int32, Int32}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Int32, Int32}"/> struct.</returns>
        public static ReadFromAdsSymbol<Int32[], Int32[]> ReadInt32Array(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Int32[], Int32[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Int32[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => ImmutableArray.Create(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Int32[], TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<Int32[], TCsharp> ReadInt32Array<TCsharp>(string name, Func<Int32[], TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Int32[], TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Int32, Int32}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Int32, Int32}"/> struct.</returns>
        public static WriteToAdsSymbol<Int32, Int32> WriteInt32(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, Int32> WriteInt32<TCsharp>(string name, Func<TCsharp, Int32> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,Int32>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Int32, Int32}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Int32, Int32}"/> struct.</returns>
        public static WriteToAdsSymbol<Int32[], Int32[]> WriteInt32Array(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, Int32[]> WriteInt32Array<TCsharp>(string name, Func<TCsharp, Int32[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, Int32[]>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Int64, Int64}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Int64, Int64}"/> struct.</returns>
        public static ReadFromAdsSymbol<Int64, Int64> ReadInt64(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Int64, Int64>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Int64, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Int64, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<Int64, TCsharp> ReadInt64<TCsharp>(string name, Func<Int64, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Int64, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Int64, Int64}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Int64, Int64}"/> struct.</returns>
        public static ReadFromAdsSymbol<Int64[], Int64[]> ReadInt64Array(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Int64[], Int64[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Int64[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => ImmutableArray.Create(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Int64[], TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<Int64[], TCsharp> ReadInt64Array<TCsharp>(string name, Func<Int64[], TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Int64[], TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Int64, Int64}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Int64, Int64}"/> struct.</returns>
        public static WriteToAdsSymbol<Int64, Int64> WriteInt64(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, Int64> WriteInt64<TCsharp>(string name, Func<TCsharp, Int64> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,Int64>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Int64, Int64}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Int64, Int64}"/> struct.</returns>
        public static WriteToAdsSymbol<Int64[], Int64[]> WriteInt64Array(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, Int64[]> WriteInt64Array<TCsharp>(string name, Func<TCsharp, Int64[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, Int64[]>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{SByte, SByte}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{SByte, SByte}"/> struct.</returns>
        public static ReadFromAdsSymbol<SByte, SByte> ReadSByte(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<SByte, SByte>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{SByte, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{SByte, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<SByte, TCsharp> ReadSByte<TCsharp>(string name, Func<SByte, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<SByte, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{SByte, SByte}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{SByte, SByte}"/> struct.</returns>
        public static ReadFromAdsSymbol<SByte[], SByte[]> ReadSByteArray(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<SByte[], SByte[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{SByte[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => ImmutableArray.Create(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{SByte[], TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<SByte[], TCsharp> ReadSByteArray<TCsharp>(string name, Func<SByte[], TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<SByte[], TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{SByte, SByte}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{SByte, SByte}"/> struct.</returns>
        public static WriteToAdsSymbol<SByte, SByte> WriteSByte(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, SByte> WriteSByte<TCsharp>(string name, Func<TCsharp, SByte> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,SByte>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{SByte, SByte}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{SByte, SByte}"/> struct.</returns>
        public static WriteToAdsSymbol<SByte[], SByte[]> WriteSByteArray(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, SByte[]> WriteSByteArray<TCsharp>(string name, Func<TCsharp, SByte[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, SByte[]>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Single, Single}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Single, Single}"/> struct.</returns>
        public static ReadFromAdsSymbol<Single, Single> ReadSingle(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Single, Single>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Single, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Single, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<Single, TCsharp> ReadSingle<TCsharp>(string name, Func<Single, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Single, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Single, Single}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Single, Single}"/> struct.</returns>
        public static ReadFromAdsSymbol<Single[], Single[]> ReadSingleArray(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Single[], Single[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Single[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => ImmutableArray.Create(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Single[], TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<Single[], TCsharp> ReadSingleArray<TCsharp>(string name, Func<Single[], TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Single[], TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Single, Single}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Single, Single}"/> struct.</returns>
        public static WriteToAdsSymbol<Single, Single> WriteSingle(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, Single> WriteSingle<TCsharp>(string name, Func<TCsharp, Single> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,Single>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{Single, Single}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{Single, Single}"/> struct.</returns>
        public static WriteToAdsSymbol<Single[], Single[]> WriteSingleArray(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, Single[]> WriteSingleArray<TCsharp>(string name, Func<TCsharp, Single[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, Single[]>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{UInt16, UInt16}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{UInt16, UInt16}"/> struct.</returns>
        public static ReadFromAdsSymbol<UInt16, UInt16> ReadUInt16(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<UInt16, UInt16>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{UInt16, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{UInt16, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<UInt16, TCsharp> ReadUInt16<TCsharp>(string name, Func<UInt16, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<UInt16, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{UInt16, UInt16}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{UInt16, UInt16}"/> struct.</returns>
        public static ReadFromAdsSymbol<UInt16[], UInt16[]> ReadUInt16Array(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<UInt16[], UInt16[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{UInt16[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => ImmutableArray.Create(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{UInt16[], TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<UInt16[], TCsharp> ReadUInt16Array<TCsharp>(string name, Func<UInt16[], TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<UInt16[], TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{UInt16, UInt16}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{UInt16, UInt16}"/> struct.</returns>
        public static WriteToAdsSymbol<UInt16, UInt16> WriteUInt16(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, UInt16> WriteUInt16<TCsharp>(string name, Func<TCsharp, UInt16> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,UInt16>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{UInt16, UInt16}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{UInt16, UInt16}"/> struct.</returns>
        public static WriteToAdsSymbol<UInt16[], UInt16[]> WriteUInt16Array(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, UInt16[]> WriteUInt16Array<TCsharp>(string name, Func<TCsharp, UInt16[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, UInt16[]>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{UInt32, UInt32}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{UInt32, UInt32}"/> struct.</returns>
        public static ReadFromAdsSymbol<UInt32, UInt32> ReadUInt32(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<UInt32, UInt32>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{UInt32, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{UInt32, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<UInt32, TCsharp> ReadUInt32<TCsharp>(string name, Func<UInt32, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<UInt32, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{UInt32, UInt32}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{UInt32, UInt32}"/> struct.</returns>
        public static ReadFromAdsSymbol<UInt32[], UInt32[]> ReadUInt32Array(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<UInt32[], UInt32[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{UInt32[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => ImmutableArray.Create(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{UInt32[], TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<UInt32[], TCsharp> ReadUInt32Array<TCsharp>(string name, Func<UInt32[], TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<UInt32[], TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{UInt32, UInt32}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{UInt32, UInt32}"/> struct.</returns>
        public static WriteToAdsSymbol<UInt32, UInt32> WriteUInt32(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, UInt32> WriteUInt32<TCsharp>(string name, Func<TCsharp, UInt32> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,UInt32>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{UInt32, UInt32}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{UInt32, UInt32}"/> struct.</returns>
        public static WriteToAdsSymbol<UInt32[], UInt32[]> WriteUInt32Array(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, UInt32[]> WriteUInt32Array<TCsharp>(string name, Func<TCsharp, UInt32[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, UInt32[]>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{UInt64, UInt64}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{UInt64, UInt64}"/> struct.</returns>
        public static ReadFromAdsSymbol<UInt64, UInt64> ReadUInt64(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<UInt64, UInt64>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{UInt64, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{UInt64, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<UInt64, TCsharp> ReadUInt64<TCsharp>(string name, Func<UInt64, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<UInt64, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{UInt64, UInt64}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{UInt64, UInt64}"/> struct.</returns>
        public static ReadFromAdsSymbol<UInt64[], UInt64[]> ReadUInt64Array(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<UInt64[], UInt64[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{UInt64[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => ImmutableArray.Create(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{UInt64[], TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<UInt64[], TCsharp> ReadUInt64Array<TCsharp>(string name, Func<UInt64[], TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<UInt64[], TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{UInt64, UInt64}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{UInt64, UInt64}"/> struct.</returns>
        public static WriteToAdsSymbol<UInt64, UInt64> WriteUInt64(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, UInt64> WriteUInt64<TCsharp>(string name, Func<TCsharp, UInt64> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,UInt64>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{UInt64, UInt64}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{UInt64, UInt64}"/> struct.</returns>
        public static WriteToAdsSymbol<UInt64[], UInt64[]> WriteUInt64Array(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, UInt64[]> WriteUInt64Array<TCsharp>(string name, Func<TCsharp, UInt64[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, UInt64[]>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{String, String}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{String, String}"/> struct.</returns>
        public static ReadFromAdsSymbol<String, String> ReadString(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<String, String>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{String, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{String, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<String, TCsharp> ReadString<TCsharp>(string name, Func<String, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<String, TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{String, String}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{String, String}"/> struct.</returns>
        public static ReadFromAdsSymbol<String[], String[]> ReadStringArray(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<String[], String[]>(name, x => x, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{String[], TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => ImmutableArray.Create(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{String[], TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<String[], TCsharp> ReadStringArray<TCsharp>(string name, Func<String[], TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<String[], TCsharp>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{String, String}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{String, String}"/> struct.</returns>
        public static WriteToAdsSymbol<String, String> WriteString(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, String> WriteString<TCsharp>(string name, Func<TCsharp, String> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp,String>(name, map, isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:WriteToAdsSymbol{String, String}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:WriteToAdsSymbol{String, String}"/> struct.</returns>
        public static WriteToAdsSymbol<String[], String[]> WriteStringArray(string name, bool isActive = true)
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
        public static WriteToAdsSymbol<TCsharp, String[]> WriteStringArray<TCsharp>(string name, Func<TCsharp, String[]> map, bool isActive = true)
        {
            return new WriteToAdsSymbol<TCsharp, String[]>(name, map, isActive);
        }
    }
}