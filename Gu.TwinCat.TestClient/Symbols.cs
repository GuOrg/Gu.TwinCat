namespace Gu.TwinCat.TestClient
{
    using System;
    using System.Collections.ObjectModel;

    public static class Symbols
    {
        public static ReadOnlyObservableCollection<Type> Types { get; } = new ReadOnlyObservableCollection<Type>(
            new ObservableCollection<Type>
            {
                typeof(bool),
                typeof(bool[]),
                typeof(byte),
                typeof(byte[]),
                typeof(char),
                typeof(char[]),
                typeof(float),
                typeof(float[]),
                typeof(double),
                typeof(double[]),
                typeof(long),
                typeof(long[]),
                typeof(int),
                typeof(int[]),
                typeof(uint),
                typeof(uint[]),
                typeof(sbyte),
                typeof(sbyte[]),
                typeof(string),
                typeof(string[]),
                typeof(TestStruct),
            });
    }
}
