using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Hard
{
    [TestClass]
    public class WildcardMatching
    {
        private static LeetCode.Hard.WildcardMatching Wildcard => new LeetCode.Hard.WildcardMatching();

        [TestMethod]
        public void WildcardMatching_01()
        {
            var s = "aa";
            var p = "a";

            Assert.IsFalse(Wildcard.IsMatch(s, p));
        }

        [TestMethod]
        public void WildcardMatching_02()
        {
            var s = "aa";
            var p = "*";

            Assert.IsTrue(Wildcard.IsMatch(s, p));
        }

        [TestMethod]
        public void WildcardMatching_03()
        {
            var s = "cb";
            var p = "?a";

            Assert.IsFalse(Wildcard.IsMatch(s, p));
        }

        [TestMethod]
        public void WildcardMatching_04()
        {
            var s = "adceb";
            var p = "a*b";

            Assert.IsTrue(Wildcard.IsMatch(s, p));
        }

        [TestMethod]
        public void WildcardMatching_05()
        {
            var s = "acdcb";
            var p = "a*c?b";

            Assert.IsFalse(Wildcard.IsMatch(s, p));
        }

        [TestMethod]
        public void WildcardMatching_06()
        {
            var s = "aaaabaaaabbbbaabbbaabbaababbabbaaaababaaabbbbbbaabbbabababbaaabaabaaaaaabbaabbbbaababbababaabbbaababbbba";
            var p = "*****b*aba***babaa*bbaba***a*aaba*b*aa**a*b**ba***a*a*";

            Assert.IsTrue(Wildcard.IsMatch(s, p));
        }

        [TestMethod]
        public void WildcardMatching_07()
        {
            var s = "abbabaaabbabbaababbabbbbbabbbabbbabaaaaababababbbabababaabbababaabbbbbbaaaabababbbaabbbbaabbbbababababbaabbaababaabbbababababbbbaaabbbbbabaaaabbababbbbaababaabbababbbbbababbbabaaaaaaaabbbbbaabaaababaaaabb";
            var p = "**aa*****ba*a*bb**aa*ab****a*aaaaaa***a*aaaa**bbabb*b*b**aaaaaaaaa*a********ba*bbb***a*ba*bb*bb**a*b*bb";

            Assert.IsFalse(Wildcard.IsMatch(s, p));
        }
    }
}