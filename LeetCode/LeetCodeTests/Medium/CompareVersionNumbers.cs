using Microsoft.VisualStudio.TestTools.UnitTesting;
using Version = LeetCode.Medium.CompareVersionNumbers;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class CompareVersionNumbers
    {
        [TestMethod]
        public void CompareVersionNumbers__0_1_is_less_then_1_1() =>
            Assert.AreEqual(-1, Version.CompareVersion("0.1", "1.1"));

        [TestMethod]
        public void CompareVersionNumbers__1_is_less_then_1_1() =>
            Assert.AreEqual(-1, Version.CompareVersion("1", "1.1"));

        [TestMethod]
        public void CompareVersionNumbers__1_0_1_is_greater_then_1() =>
            Assert.AreEqual(1, Version.CompareVersion("1.0.1", "1"));

        [TestMethod]
        public void CompareVersionNumbers__1_0_is_equal_to_1() =>
            Assert.AreEqual(0, Version.CompareVersion("1.0", "1"));
    }
}
