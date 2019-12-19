namespace Gu.TwinCat.Tests
{
    using System;
    using NUnit.Framework;

    public static class AdsTimeSpanTests
    {
        [Test]
        public static void FromMilliseconds()
        {
            Assert.AreEqual(TimeSpan.FromMilliseconds(500).TotalMilliseconds, AdsTimeSpan.FromMilliseconds(500).Milliseconds);
        }

        [Test]
        public static void FromSeconds()
        {
            Assert.AreEqual(TimeSpan.FromSeconds(3).TotalMilliseconds, AdsTimeSpan.FromSeconds(3).Milliseconds);
        }

        [Test]
        public static void FromMinutes()
        {
            Assert.AreEqual(TimeSpan.FromMinutes(3).TotalMilliseconds, AdsTimeSpan.FromMinutes(3).Milliseconds);
        }
    }
}
