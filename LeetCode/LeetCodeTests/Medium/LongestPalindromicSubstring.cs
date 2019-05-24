using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class LongestPalindromicSubstring
    {
        private static LeetCode.Medium.LongestPalindromicSubstring Substring
            => new LeetCode.Medium.LongestPalindromicSubstring();

        [TestMethod]
        public void LongestPalindromicSubstring_0() =>
            Assert.AreEqual("a", Substring.LongestPalindrome("a"));

        [TestMethod]
        public void LongestPalindromicSubstring_1() =>
            Assert.AreEqual("bab", Substring.LongestPalindrome("babad"));

        [TestMethod]
        public void LongestPalindromicSubstring_2() =>
            Assert.AreEqual("bb", Substring.LongestPalindrome("cbbd"));

        [TestMethod]
        public void LongestPalindromicSubstring_3() =>
            Assert.AreEqual("jtotj", Substring.LongestPalindrome("vaomxdtiuwqlwhgutkhxxhccsgvyoaccuicgybnqnslogtqhblegfudagpxfvjdacsxgevvepuwthdtybgflsxjdmmfumyqgpxatvdypjmlapccaxwkuxkilqqgpihyepkilhlfkdrbsefinitdcaghqmhylnixidrygdnzmgubeybczjceiybowglkywrpkfcwpsjbkcpnvfbxnpuqzhotzspgebptnhwevbkcueyzecdrjpbpxemagnwmtwikmkpqluwmvyswvxghajknjxfazshsvjkstkezdlbnkwxawlwkqnxghjzyigkvqpapvsntojnxlmtywdrommoltpbvxwqyijpkirvndwpgufgjelqvwffpuycqfwenhzrbzbdtupyutgccdjyvhptnuhxdwbmdcbpfvxvtfryszhaakwshrjseonfvjrrdefyxefqfvadlwmedpvnozobftnnsutegrtxhwitrwdpfienhdbvvykoynrsbpmzjtotjxbvemgoxreiveakmmbbvbmfbbnyfxwrueswdlxvuelbkrdxlutyukppkzjnmfmclqpkwzyylwlzsvriwomchzzqwqglpflaepoxcnnewzstvegyaowwhgvcwjhbbstvzhhvghigoazbjiikglbqlxlccrwqvyqxpbtpoqjliziwmdkzfsrqtqdkeniulsavsfqsjwnvpprvczcujihoqeanobhlsvbzmgflhykndfydbxatskf"));
    }
}