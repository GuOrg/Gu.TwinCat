namespace Gu.TwinCat.Tests
{
    using System;
    using NUnit.Framework;
    using TwinCAT.Ads;

    public static class AdsClientTests
    {
        [Ignore("Requires a running PLC.")]
        [Test]
        public static void Read()
        {
            using var client = new AdsClient(new AdsClientAutoReconnectSettings(new AmsAddress("1.2.3.4.5.6", 851), TimeSpan.FromMilliseconds(1000), InactiveSymbolHandling.Throw));
            var value = client.Read(SymbolFactory.ReadInt32("Plc.Name"));
        }
    }
}
