namespace Gu.TwinCat.TestClient
{
    using System;
    using System.ComponentModel;

    public class ReadSymbolViewModel : AbstractSymbolViewModel
    {
        private object? value;

        public object? Value
        {
            get => this.value;
            private set
            {
                if (ReferenceEquals(value, this.value))
                {
                    return;
                }

                this.value = value;
                this.OnPropertyChanged();
            }
        }

        public void Read(AdsClient client)
        {
            if (this.Type!.IsArray)
            {
                this.Value = System.Type.GetTypeCode(this.Type.GetElementType()) switch
                {
                    TypeCode.Boolean => client.Read(CreateSymbol<bool[]>()),
                    TypeCode.Byte => client.Read(CreateSymbol<byte[]>()),
                    TypeCode.Double => client.Read(CreateSymbol<double[]>()),
                    TypeCode.Char => client.Read(CreateSymbol<char[]>()),
                    TypeCode.Int16 => client.Read(CreateSymbol<short[]>()),
                    TypeCode.UInt16 => client.Read(CreateSymbol<ushort[]>()),
                    TypeCode.Int32 => client.Read(CreateSymbol<int[]>()),
                    TypeCode.UInt32 => client.Read(CreateSymbol<uint[]>()),
                    TypeCode.Int64 => client.Read(CreateSymbol<long[]>()),
                    TypeCode.UInt64 => client.Read(CreateSymbol<ulong[]>()),
                    TypeCode.Single => client.Read(CreateSymbol<float[]>()),
                    TypeCode.SByte => client.Read(CreateSymbol<sbyte[]>()),
                    TypeCode.String => client.Read(CreateSymbol<string[]>()),
                    _ => throw new InvalidEnumArgumentException("Unhandled type.")
                };
            }
            else
            {
                this.Value = Type.GetTypeCode(this.Type) switch
                {
                    TypeCode.Boolean => client.Read(CreateSymbol<bool>()),
                    TypeCode.Byte => client.Read(CreateSymbol<byte>()),
                    TypeCode.Double => client.Read(CreateSymbol<double>()),
                    TypeCode.Char => client.Read(CreateSymbol<char>()),
                    TypeCode.Int16 => client.Read(CreateSymbol<short>()),
                    TypeCode.UInt16 => client.Read(CreateSymbol<ushort>()),
                    TypeCode.Int32 => client.Read(CreateSymbol<int>()),
                    TypeCode.UInt32 => client.Read(CreateSymbol<uint>()),
                    TypeCode.Int64 => client.Read(CreateSymbol<long>()),
                    TypeCode.UInt64 => client.Read(CreateSymbol<ulong>()),
                    TypeCode.Single => client.Read(CreateSymbol<float>()),
                    TypeCode.SByte => client.Read(CreateSymbol<sbyte>()),
                    TypeCode.String => client.Read(CreateSymbol<string>()),
                    _ => throw new InvalidEnumArgumentException("Unhandled type.")
                };
            }

            ReadFromAdsSymbol<T, T> CreateSymbol<T>() => new ReadFromAdsSymbol<T, T>(this.Name, x => x, isActive: true);
        }
    }
}
