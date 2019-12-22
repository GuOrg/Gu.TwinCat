﻿namespace Gu.TwinCat.Tests
{
    using Moq;
    using NUnit.Framework;
    using TwinCAT.Ads;

    public static class SubscriptionTests
    {
        [Test]
        public static void Create()
        {
            var adsConnection = new Mock<IAdsConnection>(MockBehavior.Strict);
            adsConnection.SetupGet(x => x.IsConnected).Returns(true);
            var state = new StateInfo(AdsState.Run, 0);
            adsConnection.Setup(x => x.TryReadState(out state)).Returns(AdsErrorCode.NoError);
            var symbol = SymbolFactory.ReadInt32("Plc.Name");
            adsConnection.Setup(x => x.AddDeviceNotificationEx(symbol.Name, AdsTransMode.OnChange, 100, 2000, null, typeof(int))).Returns(1);
            using var subscription = new Subscription<int, int>(adsConnection.Object, symbol, AdsTransMode.OnChange, AdsTimeSpan.FromMilliseconds(100), AdsTimeSpan.FromSeconds(2));
            Assert.AreEqual(false, subscription.Value.HasValue);
            Assert.AreEqual(Maybe.None<int>(), subscription.Value);

            adsConnection.Raise(x => x.AdsNotificationEx += null, new AdsNotificationExEventArgs(0, null, 1, 2));
            Assert.AreEqual(true, subscription.Value.HasValue);
            Assert.AreEqual(2, subscription.Value.Value);
        }
    }
}