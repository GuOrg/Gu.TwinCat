namespace Gu.TwinCat.TestClient
{
    using System;
    using System.ComponentModel;
    using TwinCAT.Ads;

    public sealed class SubscribeSymbolViewModel : AbstractSymbolViewModel, IDisposable
    {
        private AdsTransMode transMode = AdsTransMode.OnChange;
        private AdsTimeSpan cycleTime = AdsTimeSpan.FromMilliseconds(100);
        private AdsTimeSpan maxDelay = AdsTimeSpan.FromSeconds(1);
        private object? subscription;
        private bool disposed;

        public AdsTransMode TransMode
        {
            get => this.transMode;
            set
            {
                if (value == this.transMode)
                {
                    return;
                }

                this.transMode = value;
                this.OnPropertyChanged();
            }
        }

        public AdsTimeSpan CycleTime
        {
            get => this.cycleTime;
            set
            {
                if (value == this.cycleTime)
                {
                    return;
                }

                this.cycleTime = value;
                this.OnPropertyChanged();
            }
        }

        public AdsTimeSpan MaxDelay
        {
            get => this.maxDelay;
            set
            {
                if (value == this.maxDelay)
                {
                    return;
                }

                this.maxDelay = value;
                this.OnPropertyChanged();
            }
        }

        public object? Subscription
        {
            get => this.subscription;
            private set
            {
                if (ReferenceEquals(value, this.subscription))
                {
                    return;
                }

                (this.subscription as IDisposable)?.Dispose();
                this.subscription = value;
                this.OnPropertyChanged();
            }
        }

        public void Subscribe(AdsClient client)
        {
            (this.subscription as IDisposable)?.Dispose();
            this.Subscription = this.Type switch
            {
                { IsArray: true } => Type.GetTypeCode(this.Type.GetElementType()) switch
                {
                    TypeCode.Boolean => client.Subscribe(CreateSymbol<bool[]>(), this.transMode, this.cycleTime, this.maxDelay),
                    TypeCode.Byte => client.Subscribe(CreateSymbol<byte[]>(), this.transMode, this.cycleTime, this.maxDelay),
                    TypeCode.Double => client.Subscribe(CreateSymbol<double[]>(), this.transMode, this.cycleTime, this.maxDelay),
                    TypeCode.Char => client.Subscribe(CreateSymbol<char[]>(), this.transMode, this.cycleTime, this.maxDelay),
                    TypeCode.Int16 => client.Subscribe(CreateSymbol<short[]>(), this.transMode, this.cycleTime, this.maxDelay),
                    TypeCode.UInt16 => client.Subscribe(CreateSymbol<ushort[]>(), this.transMode, this.cycleTime, this.maxDelay),
                    TypeCode.Int32 => client.Subscribe(CreateSymbol<int[]>(), this.transMode, this.cycleTime, this.maxDelay),
                    TypeCode.UInt32 => client.Subscribe(CreateSymbol<uint[]>(), this.transMode, this.cycleTime, this.maxDelay),
                    TypeCode.Int64 => client.Subscribe(CreateSymbol<long[]>(), this.transMode, this.cycleTime, this.maxDelay),
                    TypeCode.UInt64 => client.Subscribe(CreateSymbol<ulong[]>(), this.transMode, this.cycleTime, this.maxDelay),
                    TypeCode.Single => client.Subscribe(CreateSymbol<float[]>(), this.transMode, this.cycleTime, this.maxDelay),
                    TypeCode.SByte => client.Subscribe(CreateSymbol<sbyte[]>(), this.transMode, this.cycleTime, this.maxDelay),
                    TypeCode.String => client.Subscribe(CreateSymbol<string[]>(), this.transMode, this.cycleTime, this.maxDelay),
                    _ when this.Type == typeof(TestStruct) => client.Subscribe(new ReadFromAdsSymbol<TestStruct, TestStruct>(this.Name, x => x, isActive: true), this.transMode, this.cycleTime, this.maxDelay),
                    _ => throw new InvalidEnumArgumentException("Unhandled type.")
                },
                _ => Type.GetTypeCode(this.Type) switch
                {
                    TypeCode.Boolean => client.Subscribe(CreateSymbol<bool>(), this.transMode, this.cycleTime, this.maxDelay),
                    TypeCode.Byte => client.Subscribe(CreateSymbol<byte>(), this.transMode, this.cycleTime, this.maxDelay),
                    TypeCode.Double => client.Subscribe(CreateSymbol<double>(), this.transMode, this.cycleTime, this.maxDelay),
                    TypeCode.Char => client.Subscribe(CreateSymbol<char>(), this.transMode, this.cycleTime, this.maxDelay),
                    TypeCode.Int16 => client.Subscribe(CreateSymbol<short>(), this.transMode, this.cycleTime, this.maxDelay),
                    TypeCode.UInt16 => client.Subscribe(CreateSymbol<ushort>(), this.transMode, this.cycleTime, this.maxDelay),
                    TypeCode.Int32 => client.Subscribe(CreateSymbol<int>(), this.transMode, this.cycleTime, this.maxDelay),
                    TypeCode.UInt32 => client.Subscribe(CreateSymbol<uint>(), this.transMode, this.cycleTime, this.maxDelay),
                    TypeCode.Int64 => client.Subscribe(CreateSymbol<long>(), this.transMode, this.cycleTime, this.maxDelay),
                    TypeCode.UInt64 => client.Subscribe(CreateSymbol<ulong>(), this.transMode, this.cycleTime, this.maxDelay),
                    TypeCode.Single => client.Subscribe(CreateSymbol<float>(), this.transMode, this.cycleTime, this.maxDelay),
                    TypeCode.SByte => client.Subscribe(CreateSymbol<sbyte>(), this.transMode, this.cycleTime, this.maxDelay),
                    TypeCode.String => client.Subscribe(CreateSymbol<string>(), this.transMode, this.cycleTime, this.maxDelay),
                    _ => throw new InvalidEnumArgumentException("Unhandled type.")
                },
            };

            ReadFromAdsSymbol<T, T> CreateSymbol<T>() => new ReadFromAdsSymbol<T, T>(this.Name, x => x, isActive: true);
        }

        public void Unsubscribe()
        {
            this.Subscription = null;
        }

        public void Dispose()
        {
            if (this.disposed)
            {
                return;
            }

            this.disposed = true;
            (this.subscription as IDisposable)?.Dispose();
        }
    }
}
