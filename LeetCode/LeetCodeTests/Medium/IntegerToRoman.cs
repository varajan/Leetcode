using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class IntegerToRoman
    {
        private static LeetCode.Medium.IntegerToRoman Roman => new LeetCode.Medium.IntegerToRoman();

        [TestMethod]
        public void Test1_Empty_is_0() => Assert.AreEqual(string.Empty, Roman.IntToRoman(0));

        [TestMethod]
        public void Test2_III_is_3() => Assert.AreEqual("III", Roman.IntToRoman(3));

        [TestMethod]
        public void Test3_IV_is_4() => Assert.AreEqual("IV", Roman.IntToRoman(4));

        [TestMethod]
        public void Test4_IX_is_9() => Assert.AreEqual("IX", Roman.IntToRoman(9));

        [TestMethod]
        public void Test5_LVIII_is_58() => Assert.AreEqual("LVIII", Roman.IntToRoman(58));

        [TestMethod]
        public void Test6_MCMXCIV_is_1994() => Assert.AreEqual("MCMXCIV", Roman.IntToRoman(1994));

        [TestMethod]
        public void Test7_MMCDLXXIV_is_2474() => Assert.AreEqual("MMCDLXXIV", Roman.IntToRoman(2474));
   }
}