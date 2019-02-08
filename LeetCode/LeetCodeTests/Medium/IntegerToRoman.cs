using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roman = LeetCode.Medium.IntegerToRoman;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class IntegerToRoman
    {
        [TestMethod]
        public void IntegerToRoman_01_Empty_is_0() => Assert.AreEqual(string.Empty, Roman.IntToRoman(0));

        [TestMethod]
        public void IntegerToRoman_02_III_is_3() => Assert.AreEqual("III", Roman.IntToRoman(3));

        [TestMethod]
        public void IntegerToRoman_03_IV_is_4() => Assert.AreEqual("IV", Roman.IntToRoman(4));

        [TestMethod]
        public void IntegerToRoman_04_IX_is_9() => Assert.AreEqual("IX", Roman.IntToRoman(9));

        [TestMethod]
        public void IntegerToRoman_05_LVIII_is_58() => Assert.AreEqual("LVIII", Roman.IntToRoman(58));

        [TestMethod]
        public void IntegerToRoman_06_MCMXCIV_is_1994() => Assert.AreEqual("MCMXCIV", Roman.IntToRoman(1994));

        [TestMethod]
        public void IntegerToRoman_07_MMCDLXXIV_is_2474() => Assert.AreEqual("MMCDLXXIV", Roman.IntToRoman(2474));
   }
}