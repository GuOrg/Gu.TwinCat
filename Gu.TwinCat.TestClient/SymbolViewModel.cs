namespace Gu.TwinCat.TestClient
{
    using System;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Globalization;
    using System.Runtime.CompilerServices;

    public class SymbolViewModel : INotifyPropertyChanged
    {
        private string? name;
        private Type? @type;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ReadOnlyObservableCollection<Type> Types { get; } = new ReadOnlyObservableCollection<Type>(
            new ObservableCollection<Type>
            {
                typeof(bool),
                typeof(float),
                typeof(float[]),
                typeof(double),
                typeof(long),
                typeof(int),
                typeof(uint),
                typeof(string),
            });

        public string? Name
        {
            get => this.name;
            set
            {
                if (value == this.name)
                {
                    return;
                }

                this.name = value;
                this.OnPropertyChanged();
            }
        }

        public Type? Type
        {
            get => this.type;
            set
            {
                if (ReferenceEquals(value, this.type))
                {
                    return;
                }

                this.type = value;
                this.OnPropertyChanged();
            }
        }

        public object Read(AdsClient client)
        {
            return System.Type.GetTypeCode(this.type) switch
            {
                TypeCode.Boolean => (object)client.Read(CreateSymbol<bool>()),
                TypeCode.SByte => client.Read(CreateSymbol<sbyte>()),
                TypeCode.Byte => client.Read(CreateSymbol<byte>()),
                TypeCode.Int16 => client.Read(CreateSymbol<short>()),
                TypeCode.UInt16 => client.Read(CreateSymbol<ushort>()),
                TypeCode.Int32 => client.Read(CreateSymbol<int>()),
                TypeCode.UInt32 => client.Read(CreateSymbol<uint>()),
                TypeCode.Int64 => client.Read(CreateSymbol<long>()),
                TypeCode.UInt64 => client.Read(CreateSymbol<ulong>()),
                TypeCode.Single => client.Read(CreateSymbol<float>()),
                TypeCode.Double => client.Read(CreateSymbol<double>()),
                TypeCode.String => client.Read(CreateSymbol<string>()),
                _ => throw new InvalidEnumArgumentException("Unhandled type.")
            };

            ReadFromAdsSymbol<T, T> CreateSymbol<T>() => new ReadFromAdsSymbol<T, T>(this.name, x => x, isActive: true);
        }

        public void Write(AdsClient client, object value)
        {
            switch (System.Type.GetTypeCode(this.type))
            {
                case TypeCode.Boolean:
                    client.Write(CreateSymbol<bool>(), Convert.ToBoolean(value, CultureInfo.InvariantCulture));
                    return;
                case TypeCode.SByte:
                    client.Write(CreateSymbol<sbyte>(), Convert.ToSByte(value, CultureInfo.InvariantCulture));
                    return;
                case TypeCode.Byte:
                    client.Write(CreateSymbol<byte>(), Convert.ToByte(value, CultureInfo.InvariantCulture));
                    return;
                case TypeCode.Int16:
                    client.Write(CreateSymbol<short>(), Convert.ToInt16(value, CultureInfo.InvariantCulture));
                    return;
                case TypeCode.UInt16:
                    client.Write(CreateSymbol<ushort>(), Convert.ToUInt16(value, CultureInfo.InvariantCulture));
                    return;
                case TypeCode.Int32:
                    client.Write(CreateSymbol<int>(), Convert.ToInt32(value, CultureInfo.InvariantCulture));
                    return;
                case TypeCode.UInt32:
                    client.Write(CreateSymbol<uint>(), Convert.ToUInt32(value, CultureInfo.InvariantCulture));
                    return;
                case TypeCode.Int64:
                    client.Write(CreateSymbol<long>(), Convert.ToInt64(value, CultureInfo.InvariantCulture));
                    return;
                case TypeCode.UInt64:
                    client.Write(CreateSymbol<ulong>(), Convert.ToUInt64(value, CultureInfo.InvariantCulture));
                    return;
                case TypeCode.Single:
                    client.Write(CreateSymbol<float>(), Convert.ToSingle(value, CultureInfo.InvariantCulture));
                    return;
                case TypeCode.Double:
                    client.Write(CreateSymbol<double>(), Convert.ToDouble(value, CultureInfo.InvariantCulture));
                    return;
                case TypeCode.String:
                    client.Write(CreateSymbol<string>(), Convert.ToString(value, CultureInfo.InvariantCulture));
                    return;
                default:
                    throw new InvalidEnumArgumentException("Unhandled type.");
            }

            WriteToAdsSymbol<T, T> CreateSymbol<T>() => new WriteToAdsSymbol<T, T>(this.name, x => x, isActive: true);
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
