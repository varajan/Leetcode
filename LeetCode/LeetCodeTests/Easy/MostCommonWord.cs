using Microsoft.VisualStudio.TestTools.UnitTesting;
using Words = LeetCode.Easy.MostCommonWord;

namespace LeetCodeTests.Easy
{
    [TestClass]
    public class MostCommonWord
    {
        [TestMethod]
        public void Test1_Most_common_word_is_banned() => Assert.AreEqual(
            "ball",
            Words.GetMostCommonWord("Bob hit a ball, the hit BALL flew far after it was hit.", new [] {"hit"} ));

        [TestMethod]
        public void Test2_Most_common_word_is_not_banned() => Assert.AreEqual(
            "hit",
            Words.GetMostCommonWord("Bob hit a ball, the hit BALL flew far after it was hit.", new string[] {} ));

        [TestMethod]
        public void Test3_Each_word_is_banned() => Assert.AreEqual(
            string.Empty,
            Words.GetMostCommonWord("Hello, MaD world!", new [] {"hello", "mad", "world"} ));

        [TestMethod]
        public void Test4_Text_is_empty() => Assert.AreEqual(
            string.Empty,
            Words.GetMostCommonWord("", new [] {"banned"} ));
    }
}