using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class Pow
    {
        private static LeetCode.Medium.Pow PowXN => new LeetCode.Medium.Pow();

        [TestMethod]
        public void Pow_01() => Assert.AreEqual(1024, PowXN.MyPow(2, 10));

        [TestMethod]
        public void Pow_02() => Assert.AreEqual(9.261000000000001, PowXN.MyPow(2.1, 3));

        [TestMethod]
        public void Pow_03() => Assert.AreEqual(0.25, PowXN.MyPow(2, -2));

        [Timeout(1000)]
        [TestMethod]
        public void Pow_04() => Assert.AreEqual(0, PowXN.MyPow(0.00001, 2147483647));

        [Timeout(1000)]
        [TestMethod]
        public void Pow_05() => Assert.AreEqual(1, PowXN.MyPow(1, 2147483647));

        [Timeout(1000)]
        [TestMethod]
        public void Pow_06() => Assert.AreEqual(0, PowXN.MyPow(2, -2147483648));

        [Timeout(1000)]
        [TestMethod]
        public void Pow_07() => Assert.AreEqual(-1, PowXN.MyPow(-1, 2147483647));
    }
}