using Microsoft.VisualStudio.TestTools.UnitTesting;
using Str = LeetCode.Easy.ImplementStr;

namespace LeetCodeTests.Easy
{
    [TestClass]
    public class ImplementStr
    {
        [TestMethod]
        public void ImplementStr_01_Empty_haystack() => Assert.AreEqual(-1, Str.StrStr(string.Empty, "a"));

        [TestMethod]
        public void ImplementStr_02_Empty_needle() => Assert.AreEqual(0, Str.StrStr(string.Empty, string.Empty));

        [TestMethod]
        public void ImplementStr_03_Needle_is_found() => Assert.AreEqual(2, Str.StrStr("hello", "ll"));

        [TestMethod]
        public void ImplementStr_04_Needle_is_not_found() => Assert.AreEqual(-1, Str.StrStr("aaaaa", "ba"));
    }
}