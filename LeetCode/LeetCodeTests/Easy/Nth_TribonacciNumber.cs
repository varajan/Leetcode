using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Easy
{
    [TestClass]
    public class Nth_TribonacciNumber
    {
        private static LeetCode.Easy.Nth_TribonacciNumber Tribonacci => new LeetCode.Easy.Nth_TribonacciNumber();

        [Timeout(1000)]
        [TestMethod]
        public void Nth_TribonacciNumber_of_33_is_181997601() => Assert.AreEqual(181997601, Tribonacci.Tribonacci(33));

        [TestMethod]
        public void Nth_TribonacciNumber_of_0_is_0() => Assert.AreEqual(0, Tribonacci.Tribonacci(0));

        [TestMethod]
        public void Nth_TribonacciNumber_of_1_is_1() => Assert.AreEqual(1, Tribonacci.Tribonacci(1));

        [TestMethod]
        public void Nth_TribonacciNumber_of_2_is_1() => Assert.AreEqual(1, Tribonacci.Tribonacci(2));

        [TestMethod]
        public void Nth_TribonacciNumber_of_3_is_2() => Assert.AreEqual(2, Tribonacci.Tribonacci(3));

        [TestMethod]
        public void Nth_TribonacciNumber_of_4_is_4() => Assert.AreEqual(4, Tribonacci.Tribonacci(4));
    }
}