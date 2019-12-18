﻿namespace Gu.TwinCat
{
    using System;

    /// <summary>
    /// Factory methods for <see cref="ReadFromAdsSymbol{TPlc,TCsharp}"/>.
    /// </summary>
    public static partial class ReadFromAdsSymbol
    {
        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Boolean, Boolean}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Boolean, Boolean}"/> struct.</returns>
        public static ReadFromAdsSymbol<Boolean, Boolean> Boolean(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Boolean, Boolean>(name, x => x, (reader, _) => reader.ReadBoolean(), isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Boolean, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Boolean, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<Boolean, TCsharp> Boolean<TCsharp>(string name, Func<Boolean, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Boolean, TCsharp>(name, map, (reader, _) => reader.ReadBoolean(), isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Byte, Byte}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Byte, Byte}"/> struct.</returns>
        public static ReadFromAdsSymbol<Byte, Byte> Byte(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Byte, Byte>(name, x => x, (reader, _) => reader.ReadByte(), isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Byte, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Byte, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<Byte, TCsharp> Byte<TCsharp>(string name, Func<Byte, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Byte, TCsharp>(name, map, (reader, _) => reader.ReadByte(), isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Char, Char}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Char, Char}"/> struct.</returns>
        public static ReadFromAdsSymbol<Char, Char> Char(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Char, Char>(name, x => x, (reader, _) => reader.ReadChar(), isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Char, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Char, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<Char, TCsharp> Char<TCsharp>(string name, Func<Char, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Char, TCsharp>(name, map, (reader, _) => reader.ReadChar(), isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Double, Double}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Double, Double}"/> struct.</returns>
        public static ReadFromAdsSymbol<Double, Double> Double(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Double, Double>(name, x => x, (reader, _) => reader.ReadDouble(), isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Double, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Double, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<Double, TCsharp> Double<TCsharp>(string name, Func<Double, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Double, TCsharp>(name, map, (reader, _) => reader.ReadDouble(), isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Int16, Int16}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Int16, Int16}"/> struct.</returns>
        public static ReadFromAdsSymbol<Int16, Int16> Int16(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Int16, Int16>(name, x => x, (reader, _) => reader.ReadInt16(), isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Int16, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Int16, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<Int16, TCsharp> Int16<TCsharp>(string name, Func<Int16, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Int16, TCsharp>(name, map, (reader, _) => reader.ReadInt16(), isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Int32, Int32}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Int32, Int32}"/> struct.</returns>
        public static ReadFromAdsSymbol<Int32, Int32> Int32(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Int32, Int32>(name, x => x, (reader, _) => reader.ReadInt32(), isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Int32, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Int32, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<Int32, TCsharp> Int32<TCsharp>(string name, Func<Int32, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Int32, TCsharp>(name, map, (reader, _) => reader.ReadInt32(), isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Int64, Int64}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Int64, Int64}"/> struct.</returns>
        public static ReadFromAdsSymbol<Int64, Int64> Int64(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Int64, Int64>(name, x => x, (reader, _) => reader.ReadInt64(), isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Int64, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Int64, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<Int64, TCsharp> Int64<TCsharp>(string name, Func<Int64, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Int64, TCsharp>(name, map, (reader, _) => reader.ReadInt64(), isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{SByte, SByte}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{SByte, SByte}"/> struct.</returns>
        public static ReadFromAdsSymbol<SByte, SByte> SByte(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<SByte, SByte>(name, x => x, (reader, _) => reader.ReadSByte(), isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{SByte, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{SByte, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<SByte, TCsharp> SByte<TCsharp>(string name, Func<SByte, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<SByte, TCsharp>(name, map, (reader, _) => reader.ReadSByte(), isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Single, Single}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Single, Single}"/> struct.</returns>
        public static ReadFromAdsSymbol<Single, Single> Single(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Single, Single>(name, x => x, (reader, _) => reader.ReadSingle(), isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{Single, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{Single, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<Single, TCsharp> Single<TCsharp>(string name, Func<Single, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<Single, TCsharp>(name, map, (reader, _) => reader.ReadSingle(), isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{UInt16, UInt16}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{UInt16, UInt16}"/> struct.</returns>
        public static ReadFromAdsSymbol<UInt16, UInt16> UInt16(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<UInt16, UInt16>(name, x => x, (reader, _) => reader.ReadUInt16(), isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{UInt16, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{UInt16, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<UInt16, TCsharp> UInt16<TCsharp>(string name, Func<UInt16, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<UInt16, TCsharp>(name, map, (reader, _) => reader.ReadUInt16(), isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{UInt32, UInt32}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{UInt32, UInt32}"/> struct.</returns>
        public static ReadFromAdsSymbol<UInt32, UInt32> UInt32(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<UInt32, UInt32>(name, x => x, (reader, _) => reader.ReadUInt32(), isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{UInt32, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{UInt32, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<UInt32, TCsharp> UInt32<TCsharp>(string name, Func<UInt32, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<UInt32, TCsharp>(name, map, (reader, _) => reader.ReadUInt32(), isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{UInt64, UInt64}"/> struct.
        /// </summary>
        /// <param name="name">The symbol name.</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{UInt64, UInt64}"/> struct.</returns>
        public static ReadFromAdsSymbol<UInt64, UInt64> UInt64(string name, bool isActive = true)
        {
            return new ReadFromAdsSymbol<UInt64, UInt64>(name, x => x, (reader, _) => reader.ReadUInt64(), isActive);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="T:ReadFromAdsSymbol{UInt64, TCsharp}"/> struct.
        /// </summary>
        /// <typeparam name="TCsharp">The c# type.</typeparam>
        /// <param name="name">The symbol name.</param>
        /// <param name="map">The mapping ex x => Length.FromMillimetres(x).</param>
        /// <param name="isActive">Specifies if the symbol is currently active.</param>
        /// <returns>A new instance of the <see cref="T:ReadFromAdsSymbol{UInt64, TCsharp}"/> struct.</returns>
        public static ReadFromAdsSymbol<UInt64, TCsharp> UInt64<TCsharp>(string name, Func<UInt64, TCsharp> map, bool isActive = true)
        {
            return new ReadFromAdsSymbol<UInt64, TCsharp>(name, map, (reader, _) => reader.ReadUInt64(), isActive);
        }

    }
}