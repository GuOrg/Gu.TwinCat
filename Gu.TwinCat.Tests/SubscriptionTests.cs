﻿namespace Gu.TwinCat.Tests
{
    using System;
    using Moq;
    using NUnit.Framework;
    using TwinCAT;
    using TwinCAT.Ads;

    public static class SubscriptionTests
    {
        [Test]
        public static void CreateInt32()
        {
            var adsConnection = new Mock<IAdsConnection>(MockBehavior.Strict);
            adsConnection.SetupGet(x => x.IsConnected).Returns(true);
            var state = new StateInfo(AdsState.Run, 0);
            adsConnection.Setup(x => x.TryReadState(out state)).Returns(AdsErrorCode.NoError);
            var symbol = SymbolFactory.ReadInt32("Plc.Name");
            adsConnection.Setup(x => x.AddDeviceNotificationEx(symbol.Name, AdsTransMode.OnChange, 100, 2000, null, typeof(int))).Returns(1);
            using var subscription = new Subscription<int, int>(adsConnection.Object, symbol, AdsTransMode.OnChange, AdsTimeSpan.FromMilliseconds(100), AdsTimeSpan.FromSeconds(2));
            Assert.AreEqual(null, subscription.LastException);
            Assert.AreEqual(false, subscription.Value.HasValue);
            Assert.AreEqual(Maybe.None<int>(), subscription.Value);

            adsConnection.Raise(x => x.AdsNotificationEx += null, new AdsNotificationExEventArgs(0, null, 1, 2));
            Assert.AreEqual(null, subscription.LastException);
            Assert.AreEqual(true, subscription.Value.HasValue);
            Assert.AreEqual(2, subscription.Value.Value);
        }

        [Test]
        public static void CreateString()
        {
            var adsConnection = new Mock<IAdsConnection>(MockBehavior.Strict);
            adsConnection.SetupGet(x => x.IsConnected).Returns(true);
            var state = new StateInfo(AdsState.Run, 0);
            adsConnection.Setup(x => x.TryReadState(out state)).Returns(AdsErrorCode.NoError);
            var symbol = SymbolFactory.ReadString("Plc.Name");
            adsConnection.Setup(x => x.AddDeviceNotificationEx(symbol.Name, AdsTransMode.OnChange, 100, 2000, null, typeof(string), new[] { 30 })).Returns(1);
            adsConnection.Setup(x => x.ReadSymbolInfo(symbol.Name)).Returns(Mock.Of<ITcAdsSymbol>(x => x.Size == 30));
            using var subscription = new Subscription<string, string>(adsConnection.Object, symbol, AdsTransMode.OnChange, AdsTimeSpan.FromMilliseconds(100), AdsTimeSpan.FromSeconds(2));
            Assert.AreEqual(null, subscription.LastException);
            Assert.AreEqual(false, subscription.Value.HasValue);
            Assert.AreEqual(Maybe.None<string>(), subscription.Value);

            adsConnection.Raise(x => x.AdsNotificationEx += null, new AdsNotificationExEventArgs(0, null, 1, "abc"));
            Assert.AreEqual(null, subscription.LastException);
            Assert.AreEqual(true, subscription.Value.HasValue);
            Assert.AreEqual("abc", subscription.Value.Value);
        }

        [Test]
        public static void CreateFloatArray()
        {
            var adsConnection = new Mock<IAdsConnection>(MockBehavior.Strict);
            adsConnection.SetupGet(x => x.IsConnected).Returns(true);
            var state = new StateInfo(AdsState.Run, 0);
            adsConnection.Setup(x => x.TryReadState(out state)).Returns(AdsErrorCode.NoError);
            var symbol = SymbolFactory.ReadSingleArray("Plc.Name");
            adsConnection.Setup(x => x.AddDeviceNotificationEx(symbol.Name, AdsTransMode.OnChange, 100, 2000, null, typeof(float[]), new[] { 3 })).Returns(1);
            adsConnection.Setup(x => x.ReadSymbolInfo(symbol.Name)).Returns(Mock.Of<ITcAdsSymbol>(x => x.Size == 12));
            using var subscription = new Subscription<float[], float[]>(adsConnection.Object, symbol, AdsTransMode.OnChange, AdsTimeSpan.FromMilliseconds(100), AdsTimeSpan.FromSeconds(2));
            Assert.AreEqual(null, subscription.LastException);
            Assert.AreEqual(false, subscription.Value.HasValue);
            Assert.AreEqual(Maybe.None<float[]>(), subscription.Value);

            adsConnection.Raise(x => x.AdsNotificationEx += null, new AdsNotificationExEventArgs(0, null, 1, new float[] { 1, 2, 3 }));
            Assert.AreEqual(null, subscription.LastException);
            Assert.AreEqual(true, subscription.Value.HasValue);
            Assert.AreEqual(new float[] { 1, 2, 3 }, subscription.Value.Value);
        }

        [Test]
        public static void CreateMapped()
        {
            var adsConnection = new Mock<IAdsConnection>(MockBehavior.Strict);
            adsConnection.SetupGet(x => x.IsConnected).Returns(true);
            var state = new StateInfo(AdsState.Run, 0);
            adsConnection.Setup(x => x.TryReadState(out state)).Returns(AdsErrorCode.NoError);
            var symbol = SymbolFactory.ReadSingle("Plc.Name", x => Math.Round(x, 2));
            adsConnection.Setup(x => x.AddDeviceNotificationEx(symbol.Name, AdsTransMode.OnChange, 100, 2000, null, typeof(float))).Returns(1);
            using var subscription = new Subscription<float, double>(adsConnection.Object, symbol, AdsTransMode.OnChange, AdsTimeSpan.FromMilliseconds(100), AdsTimeSpan.FromSeconds(2));
            Assert.AreEqual(null, subscription.LastException);
            Assert.AreEqual(false, subscription.Value.HasValue);
            Assert.AreEqual(Maybe.None<double>(), subscription.Value);

            adsConnection.Raise(x => x.AdsNotificationEx += null, new AdsNotificationExEventArgs(0, null, 1, 1.23456f));
            Assert.AreEqual(null, subscription.LastException);
            Assert.AreEqual(true, subscription.Value.HasValue);
            Assert.AreEqual(1.23, subscription.Value.Value);
        }

        [Test]
        public static void CreateWhenDisconnectedThenConnect()
        {
            var adsConnection = new Mock<IAdsConnection>(MockBehavior.Strict);
            adsConnection.SetupGet(x => x.IsConnected).Returns(false);
            var symbol = SymbolFactory.ReadInt32("Plc.Name");
            using var subscription = new Subscription<int, int>(adsConnection.Object, symbol, AdsTransMode.OnChange, AdsTimeSpan.FromMilliseconds(100), AdsTimeSpan.FromSeconds(2));
            Assert.AreEqual(null, subscription.LastException);
            Assert.AreEqual(false, subscription.Value.HasValue);
            Assert.AreEqual(Maybe.None<int>(), subscription.Value);

            adsConnection.SetupGet(x => x.IsConnected).Returns(true);
            var state = new StateInfo(AdsState.Run, 0);
            adsConnection.Setup(x => x.TryReadState(out state)).Returns(AdsErrorCode.NoError);
            adsConnection.Setup(x => x.AddDeviceNotificationEx(symbol.Name, AdsTransMode.OnChange, 100, 2000, null, typeof(int))).Returns(1);
            adsConnection.Raise(x => x.ConnectionStateChanged += null, new ConnectionStateChangedEventArgs(ConnectionStateChangedReason.Established, ConnectionState.Connected, ConnectionState.Disconnected));
            Assert.AreEqual(null, subscription.LastException);
            Assert.AreEqual(false, subscription.Value.HasValue);
            Assert.AreEqual(Maybe.None<int>(), subscription.Value);

            adsConnection.Raise(x => x.AdsNotificationEx += null, new AdsNotificationExEventArgs(0, null, 1, 2));
            Assert.AreEqual(null, subscription.LastException);
            Assert.AreEqual(true, subscription.Value.HasValue);
            Assert.AreEqual(2, subscription.Value.Value);
        }
    }
}
