using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Easy
{
    [TestClass]
    public class ImplementStr
    {
        private static LeetCode.Easy.ImplementStr Str => new LeetCode.Easy.ImplementStr();

        [TestMethod]
        public void Test01_Empty_haystack() => Assert.AreEqual(-1, Str.StrStr(string.Empty, "a"));

        [TestMethod]
        public void Test02_Empty_needle() => Assert.AreEqual(0, Str.StrStr(string.Empty, string.Empty));

        [TestMethod]
        public void Test3_Needle_is_found() => Assert.AreEqual(2, Str.StrStr("hello", "ll"));

        [TestMethod]
        public void Test4_Needle_is_not_found() => Assert.AreEqual(-1, Str.StrStr("aaaaa", "ba"));
    }
}