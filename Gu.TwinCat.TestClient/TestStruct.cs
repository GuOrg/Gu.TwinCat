namespace Gu.TwinCat.TestClient
{
#pragma warning disable CA1815 // Override equals and operator equals on value types
    public struct TestStruct
#pragma warning restore CA1815 // Override equals and operator equals on value types
    {
#pragma warning disable CA1720 // Identifier contains type name
        public bool BOOL { get; set; }

        public uint UDINT { get; set; }

        public byte BYTE { get; set; }

        public ushort UINT { get; set; }
#pragma warning restore CA1720 // Identifier contains type name
    }
}
