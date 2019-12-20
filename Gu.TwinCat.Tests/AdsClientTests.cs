namespace Gu.TwinCat.Tests
{
    using NUnit.Framework;

    public static class AdsClientTests
    {
        [Ignore("Requires a running PLC.")]
        [Test]
        public static void Read()
        {
            using var client = new AdsClient();
            client.Connect("1.2.3.4.5.6", 851);
            var value = client.Read(ReadFromAdsSymbol.Int32("Plc.Name"));
        }
    }
}
