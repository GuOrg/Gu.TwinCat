namespace Gu.TwinCat.Tests
{
    using NUnit.Framework;
    using TwinCAT.Ads;

    public static class AdsClientTests
    {
        [Ignore("Requires a running PLC.")]
        [Test]
        public static void Read()
        {
            using var client = new AdsClient(
                new AutoReconnectSettings(
                    address: new AmsAddress("1.2.3.4.5.6", 851),
                    reconnectInterval: AdsTimeSpan.FromSeconds(1),
                    inactiveSymbolHandling: InactiveSymbolHandling.Throw));
            var value = client.Read(SymbolFactory.ReadInt32("Plc.Name"));
        }
    }
}
