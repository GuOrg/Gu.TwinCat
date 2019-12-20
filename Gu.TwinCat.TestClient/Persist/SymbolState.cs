namespace Gu.TwinCat.TestClient
{
    using System;

    public class SymbolState
    {
        public SymbolState(string name, Type type)
        {
            this.Name = name;
            this.Type = type;
        }

        public string Name { get; }

        public Type Type { get; }
    }
}
