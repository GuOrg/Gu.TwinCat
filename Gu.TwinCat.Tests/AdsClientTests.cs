namespace Gu.TwinCat.Tests
{
    using System;
    using NUnit.Framework;
    using TwinCAT.Ads;

    public static class AdsClientTests
    {
        [Test]
        public static void ReadInActiveThrows()
        {
            using var client = new AdsClient(
                new AutoReconnectSettings(
                    address: new AmsAddress("1.2.3.4.5.6", 851),
                    reconnectInterval: AdsTimeSpan.FromSeconds(1),
                    inactiveSymbolHandling: InactiveSymbolHandling.Throw));

            var exception = Assert.Throws<InvalidOperationException>(() => client.Read(SymbolFactory.ReadInt32("Plc.ReadOnly", isActive: false)));
            Assert.AreEqual("Reading inactive symbol is not allowed.", exception.Message);
        }

        [Test]
        public static void ReadInActiveReturnsDefault()
        {
            using var client = new AdsClient(
                new AutoReconnectSettings(
                    address: new AmsAddress("1.2.3.4.5.6", 851),
                    reconnectInterval: AdsTimeSpan.FromSeconds(1),
                    inactiveSymbolHandling: InactiveSymbolHandling.UseDefault));

            Assert.AreEqual(0, client.Read(SymbolFactory.ReadInt32("Plc.ReadOnly", isActive: false)));
        }

        [Test]
        public static void WriteInActiveThrows()
        {
            using var client = new AdsClient(
                new AutoReconnectSettings(
                    address: new AmsAddress("1.2.3.4.5.6", 851),
                    reconnectInterval: AdsTimeSpan.FromSeconds(1),
                    inactiveSymbolHandling: InactiveSymbolHandling.Throw));

            var exception = Assert.Throws<InvalidOperationException>(() => client.Write(SymbolFactory.WriteInt32("Plc.ReadOnly", isActive: false), 1));
            Assert.AreEqual("Writing inactive symbol is not allowed.", exception.Message);
        }

        [Test]
        public static void WriteInActiveReturnsDefault()
        {
            using var client = new AdsClient(
                new AutoReconnectSettings(
                    address: new AmsAddress("1.2.3.4.5.6", 851),
                    reconnectInterval: AdsTimeSpan.FromSeconds(1),
                    inactiveSymbolHandling: InactiveSymbolHandling.UseDefault));

            client.Write(SymbolFactory.WriteInt32("Plc.ReadOnly", isActive: false), 2);
        }

        [Test]
        public static void SubscribeInActiveThrows()
        {
            using var client = new AdsClient(
                new AutoReconnectSettings(
                    address: new AmsAddress("1.2.3.4.5.6", 851),
                    reconnectInterval: AdsTimeSpan.FromSeconds(1),
                    inactiveSymbolHandling: InactiveSymbolHandling.Throw));

            var exception = Assert.Throws<InvalidOperationException>(() => client.Subscribe(SymbolFactory.ReadInt32("Plc.ReadOnly", isActive: false), AdsTransMode.OnChange, AdsTimeSpan.FromMilliseconds(100)));
            Assert.AreEqual("Subscribing to inactive symbol is not allowed.", exception.Message);
        }

        [Test]
        public static void SubscribeInActiveReturnsDefault()
        {
            using var client = new AdsClient(
                new AutoReconnectSettings(
                    address: new AmsAddress("1.2.3.4.5.6", 851),
                    reconnectInterval: AdsTimeSpan.FromSeconds(1),
                    inactiveSymbolHandling: InactiveSymbolHandling.UseDefault));

            using var subscription = client.Subscribe(SymbolFactory.ReadInt32("Plc.ReadOnly", isActive: false), AdsTransMode.OnChange, AdsTimeSpan.FromMilliseconds(100));
            Assert.AreEqual(true, subscription.Value.HasValue);
            Assert.AreEqual(0, subscription.Value.Value);
        }
    }
}
