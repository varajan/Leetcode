using Microsoft.VisualStudio.TestTools.UnitTesting;
using Decoder = LeetCode.Medium.DecodeWays;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class NumDecodings
    {
        [TestMethod]
        public void NumDecodings_12_code_has_2_ways() => Assert.AreEqual(2, Decoder.NumDecodings("12"));

        [TestMethod]
        public void NumDecodings_Empty_code_has_0_ways() => Assert.AreEqual(0, Decoder.NumDecodings(""));

        [TestMethod]
        public void NumDecodings_0_code_has_0_ways() => Assert.AreEqual(0, Decoder.NumDecodings("0"));

        [TestMethod]
        public void NumDecodings_00_code_has_0_ways() => Assert.AreEqual(0, Decoder.NumDecodings("00"));

        [TestMethod]
        public void NumDecodings_01_code_has_0_ways() => Assert.AreEqual(0, Decoder.NumDecodings("01"));

        [TestMethod]
        public void NumDecodings_10_code_has_1_way() => Assert.AreEqual(1, Decoder.NumDecodings("10"));

        //[Timeout(4000)]
        [TestMethod]
        public void NumDecodings_long_long_code_has_589824_ways() => Assert.AreEqual(
            589824,
            Decoder.NumDecodings("4757562545844617494555774581341211511296816786586787755257741178599337186486723247528324612117156948"));
    }
}