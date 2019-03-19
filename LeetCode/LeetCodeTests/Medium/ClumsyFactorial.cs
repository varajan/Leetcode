using Microsoft.VisualStudio.TestTools.UnitTesting;
using Factorial = LeetCode.Medium.ClumsyFactorial;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class ClumsyFactorial
    {
        [TestMethod]
        public void ClumsyFactorial_4_is_7() => Assert.AreEqual(7, Factorial.Clumsy(4));

        [TestMethod]
        public void ClumsyFactorial_5_is_7() => Assert.AreEqual(7, Factorial.Clumsy(5));

        [TestMethod]
        public void ClumsyFactorial_10_is_12() => Assert.AreEqual(12, Factorial.Clumsy(10));

        [TestMethod]
        [Timeout(30)]
        public void ClumsyFactorial_8464_is_100() => Assert.AreEqual(8465, Factorial.Clumsy(8464));
    }
}