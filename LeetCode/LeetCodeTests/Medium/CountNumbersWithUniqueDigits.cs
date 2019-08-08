using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class CountNumbersWithUniqueDigits
    {
        private static LeetCode.Medium.CountNumbersWithUniqueDigits Digits => new LeetCode.Medium.CountNumbersWithUniqueDigits();

        [Timeout(500)]
        [TestMethod]
        public void CountNumbersWithUniqueDigits_01() => Assert.AreEqual(10, Digits.Count(1));

        [Timeout(500)]
        [TestMethod]
        public void CountNumbersWithUniqueDigits_02() => Assert.AreEqual(91, Digits.Count(2));

        [Timeout(500)]
        [TestMethod]
        public void CountNumbersWithUniqueDigits_03() => Assert.AreEqual(739, Digits.Count(3));

        [Timeout(500)]
        [TestMethod]
        public void CountNumbersWithUniqueDigits_04() => Assert.AreEqual(5_275, Digits.Count(4));

        [Timeout(500)]
        [TestMethod]
        public void CountNumbersWithUniqueDigits_05() => Assert.AreEqual(32_491, Digits.Count(5));

        [Timeout(500)]
        [TestMethod]
        public void CountNumbersWithUniqueDigits_06() => Assert.AreEqual(168_571, Digits.Count(6));

        [Timeout(500)]
        [TestMethod]
        public void CountNumbersWithUniqueDigits_07() => Assert.AreEqual(712_891, Digits.Count(7));

        [Timeout(500)]
        [TestMethod]
        public void CountNumbersWithUniqueDigits_08() => Assert.AreEqual(2_345_851, Digits.Count(8));

        [Timeout(500)]
        [TestMethod]
        public void CountNumbersWithUniqueDigits_09() => Assert.AreEqual(5_611_771, Digits.Count(9));

        [Timeout(500)]
        [TestMethod]
        public void CountNumbersWithUniqueDigits_10() => Assert.AreEqual(8_877_691, Digits.Count(10));
    }
}