using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roman = LeetCode.Easy.RomanToInteger;

namespace LeetCodeTests.Easy
{
    [TestClass]
    public class RomanToInteger
    {
        [TestMethod]
        public void RomanToInteger_01_Empty_is_0() => Assert.AreEqual(0, Roman.RomanToInt(string.Empty));

        [TestMethod]
        public void RomanToInteger_02_III_is_3() => Assert.AreEqual(3, Roman.RomanToInt("III"));

        [TestMethod]
        public void RomanToInteger_03_IV_is_4() => Assert.AreEqual(4, Roman.RomanToInt("IV"));

        [TestMethod]
        public void RomanToInteger_04_IX_is_9() => Assert.AreEqual(9, Roman.RomanToInt("IX"));

        [TestMethod]
        public void RomanToInteger_05_LVIII_is_58() => Assert.AreEqual(58, Roman.RomanToInt("LVIII"));

        [TestMethod]
        public void RomanToInteger_06_MCMXCIV_is_1994() => Assert.AreEqual(1994, Roman.RomanToInt("MCMXCIV"));

        [TestMethod]
        public void RomanToInteger_07_MMCDLXXIV_is_2474() => Assert.AreEqual(2474, Roman.RomanToInt("MMCDLXXIV"));
   }
}