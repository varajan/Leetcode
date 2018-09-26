using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Easy
{
    [TestClass]
    public class RomanToInteger
    {
        private static LeetCode.Easy.RomanToInteger Roman => new LeetCode.Easy.RomanToInteger();

        [TestMethod]
        public void Test1_Empty_is_0() => Assert.AreEqual(0, Roman.RomanToInt(string.Empty));

        [TestMethod]
        public void Test2_III_is_3() => Assert.AreEqual(3, Roman.RomanToInt("III"));

        [TestMethod]
        public void Test3_IV_is_4() => Assert.AreEqual(4, Roman.RomanToInt("IV"));

        [TestMethod]
        public void Test4_IX_is_9() => Assert.AreEqual(9, Roman.RomanToInt("IX"));

        [TestMethod]
        public void Test5_LVIII_is_58() => Assert.AreEqual(58, Roman.RomanToInt("LVIII"));

        [TestMethod]
        public void Test6_MCMXCIV_is_1994() => Assert.AreEqual(1994, Roman.RomanToInt("MCMXCIV"));

        [TestMethod]
        public void Test7_MMCDLXXIV_is_2474() => Assert.AreEqual(2474, Roman.RomanToInt("MMCDLXXIV"));
   }
}