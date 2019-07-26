using Microsoft.VisualStudio.TestTools.UnitTesting;
using Decoder = LeetCode.Hard.DecodeWays2;

namespace LeetCodeTests.Hard
{
    [TestClass]
    public class DecodeWays
    {
        [Timeout(2000)]
        [TestMethod]
        public void DecodeWays_x_is_9() => Assert.AreEqual(9, Decoder.NumDecodings("*"));

        [Timeout(2000)]
        [TestMethod]
        public void DecodeWays_1x_is_18() => Assert.AreEqual(18, Decoder.NumDecodings("1*"));

        [Timeout(2000)]
        [TestMethod]
        public void DecodeWays_xx_is_96() => Assert.AreEqual(96, Decoder.NumDecodings("**"));

        [Timeout(2000)]
        [TestMethod]
        public void DecodeWays_xxxxxxx_is_11859129() => Assert.AreEqual(11859129, Decoder.NumDecodings("*******"));

        [Timeout(5000)]
        [TestMethod]
        public void DecodeWays_1xxxxxxx0_is_4232034() => Assert.AreEqual(4232034, Decoder.NumDecodings("1*******0"));

        [Timeout(25000)]
        [TestMethod]
        public void DecodeWays_11xxxxxxx0_is_6504516() => Assert.AreEqual(6504516, Decoder.NumDecodings("11*******0"));
    }
}