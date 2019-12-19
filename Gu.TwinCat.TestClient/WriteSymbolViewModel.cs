namespace Gu.TwinCat.TestClient
{
    using System;
    using System.ComponentModel;
    using System.Globalization;

    public class WriteSymbolViewModel : AbstractSymbolViewModel
    {
        private object? value;

        public object? Value
        {
            get => this.value;
            set
            {
                if (ReferenceEquals(value, this.value))
                {
                    return;
                }

                this.value = value;
                this.OnPropertyChanged();
            }
        }

        public void Write(AdsClient client)
        {
            switch (System.Type.GetTypeCode(this.Type))
            {
                case TypeCode.Boolean:
                    client.Write(CreateSymbol<bool>(), Convert.ToBoolean(this.value, CultureInfo.InvariantCulture));
                    return;
                case TypeCode.SByte:
                    client.Write(CreateSymbol<sbyte>(), Convert.ToSByte(this.value, CultureInfo.InvariantCulture));
                    return;
                case TypeCode.Byte:
                    client.Write(CreateSymbol<byte>(), Convert.ToByte(this.value, CultureInfo.InvariantCulture));
                    return;
                case TypeCode.Int16:
                    client.Write(CreateSymbol<short>(), Convert.ToInt16(this.value, CultureInfo.InvariantCulture));
                    return;
                case TypeCode.UInt16:
                    client.Write(CreateSymbol<ushort>(), Convert.ToUInt16(this.value, CultureInfo.InvariantCulture));
                    return;
                case TypeCode.Int32:
                    client.Write(CreateSymbol<int>(), Convert.ToInt32(this.value, CultureInfo.InvariantCulture));
                    return;
                case TypeCode.UInt32:
                    client.Write(CreateSymbol<uint>(), Convert.ToUInt32(this.value, CultureInfo.InvariantCulture));
                    return;
                case TypeCode.Int64:
                    client.Write(CreateSymbol<long>(), Convert.ToInt64(this.value, CultureInfo.InvariantCulture));
                    return;
                case TypeCode.UInt64:
                    client.Write(CreateSymbol<ulong>(), Convert.ToUInt64(this.value, CultureInfo.InvariantCulture));
                    return;
                case TypeCode.Single:
                    client.Write(CreateSymbol<float>(), Convert.ToSingle(this.value, CultureInfo.InvariantCulture));
                    return;
                case TypeCode.Double:
                    client.Write(CreateSymbol<double>(), Convert.ToDouble(this.value, CultureInfo.InvariantCulture));
                    return;
                case TypeCode.String:
                    client.Write(CreateSymbol<string>(), Convert.ToString(this.value, CultureInfo.InvariantCulture));
                    return;
                default:
                    throw new InvalidEnumArgumentException("Unhandled type.");
            }

            WriteToAdsSymbol<T, T> CreateSymbol<T>() => new WriteToAdsSymbol<T, T>(this.Name, x => x, isActive: true);
        }
    }
}
