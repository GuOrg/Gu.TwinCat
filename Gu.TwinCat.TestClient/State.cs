namespace Gu.TwinCat.TestClient
{
    using System;
    using System.Collections.Generic;

    public class State
    {
        public State(string netId, int port, IReadOnlyList<SymbolState> readSymbols, IReadOnlyList<SymbolState> writeSymbols)
        {
            this.NetId = netId;
            this.Port = port;
            this.ReadSymbols = readSymbols;
            this.WriteSymbols = writeSymbols;
        }

        public string NetId { get; }

        public int Port { get; }

        public IReadOnlyList<SymbolState> ReadSymbols { get; }

        public IReadOnlyList<SymbolState> WriteSymbols { get; }

        public class SymbolState
        {
            public SymbolState(string name, Type type)
            {
                this.Name = name;
                this.Type = type;
            }

            public string Name { get;  }

            public Type Type { get;  }
        }
    }
}
