using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Hard
{
    [TestClass]
    public class InterleavingString
    {
        private static LeetCode.Hard.InterleavingString Interleaving => new LeetCode.Hard.InterleavingString();

        [TestMethod]
        public void InterleavingString_01()
        {
            var s1 = "aabcc";
            var s2 = "dbbca";
            var s3 = "aadbbcbcac";

            Assert.IsTrue(Interleaving.IsInterleave(s1, s2, s3));
        }

        [TestMethod]
        public void InterleavingString_02()
        {
            var s1 = "aabcc";
            var s2 = "dbbca";
            var s3 = "aadbbbaccc";

            Assert.IsFalse(Interleaving.IsInterleave(s1, s2, s3));
        }

        [TestMethod]
        public void InterleavingString_03()
        {
            var s1 = "aabcc";
            var s2 = "dbbca";
            var s3 = "aadbcbbcac";

            Assert.IsTrue(Interleaving.IsInterleave(s1, s2, s3));
        }

        [TestMethod]
        public void InterleavingString_04()
        {
            var s1 = "aacaac";
            var s2 = "aacaaeaac";
            var s3 = "aacaaeaaeaacaac";

            Assert.IsFalse(Interleaving.IsInterleave(s1, s2, s3));
        }

        [TestMethod]
        public void InterleavingString_05()
        {
            var s1= "bbbbbabbbbabaababaaaabbababbaaabbabbaaabaaaaababbbababbbbbabbbbababbabaabababbbaabababababbbaaababaa";
            var s2 = "babaaaabbababbbabbbbaabaabbaabbbbaabaaabaababaaaabaaabbaaabaaaabaabaabbbbbbbbbbbabaaabbababbabbabaab";
            var s3 = "babbbabbbaaabbababbbbababaabbabaabaaabbbbabbbaaabbbaaaaabbbbaabbaaabababbaaaaaabababbababaababbababbbababbbbaaaabaabbabbaaaaabbabbaaaabbbaabaaabaababaababbaaabbbbbabbbbaabbabaabbbbabaaabbababbabbabbab";
            Assert.IsFalse(Interleaving.IsInterleave(s1, s2, s3));
        }
    }
}