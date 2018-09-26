using LeetCode.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Easy
{
    [TestClass]
    public class ImplementStr
    {
        private LeetCode.Easy.ImplementStr Str => new LeetCode.Easy.ImplementStr();

        [TestMethod]
        public void EmptyNeedle()
        {
            Assert.AreEqual(Str.StrStr(string.Empty, string.Empty), 0);
        }

        [TestMethod]
        public void ExistedNeedle()
        {
            Assert.AreEqual(Str.StrStr("hello", "ll"), 2);
        }

        [TestMethod]
        public void NonExistedNeedle()
        {
            Assert.AreEqual(Str.StrStr("aaaaa", "ba"), -1);
        }
    }
}