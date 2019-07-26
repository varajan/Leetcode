using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome = LeetCode.Medium.PrimePalindrome;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class PrimePalindrome
    {
        [Timeout(200)]
        [TestMethod]
        public void PrimePalindrome_of_1_is_2() => Assert.AreEqual(2, Palindrome.GetPrimePalindrome(1));

        [Timeout(200)]
        [TestMethod]
        public void PrimePalindrome_of_2_is_2() => Assert.AreEqual(2, Palindrome.GetPrimePalindrome(2));

        [Timeout(200)]
        [TestMethod]
        public void PrimePalindrome_of_4_is_5() => Assert.AreEqual(5, Palindrome.GetPrimePalindrome(4));

        [Timeout(200)]
        [TestMethod]
        public void PrimePalindrome_of_6_is_7() => Assert.AreEqual(7, Palindrome.GetPrimePalindrome(6));

        [Timeout(200)]
        [TestMethod]
        public void PrimePalindrome_of_8_is_11() => Assert.AreEqual(11, Palindrome.GetPrimePalindrome(8));

        [Timeout(200)]
        [TestMethod]
        public void PrimePalindrome_of_13_is_101() => Assert.AreEqual(101, Palindrome.GetPrimePalindrome(13));

        [Timeout(200)]
        [TestMethod]
        public void PrimePalindrome_of_10_is_11() => Assert.AreEqual(11, Palindrome.GetPrimePalindrome(10));

        [Timeout(200)]
        [TestMethod]
        public void PrimePalindrome_of_9965700_is_9978799() =>
            Assert.AreEqual(9978799, Palindrome.GetPrimePalindrome(9965700));

        [Timeout(1000)]
        [TestMethod]
        public void PrimePalindrome_of_9989900_is_100030001() =>
            Assert.AreEqual(100030001, Palindrome.GetPrimePalindrome(9989900));

        [Timeout(1000)]
        [TestMethod]
        public void PrimePalindrome_of_45887963_is_100030001() =>
            Assert.AreEqual(100030001, Palindrome.GetPrimePalindrome(45887963));

        [Timeout(1000)]
        [TestMethod]
        public void PrimePalindrome_of_100000000_is_100030001() =>
            Assert.AreEqual(100030001, Palindrome.GetPrimePalindrome(100000000));

        [Timeout(1000)]
        [TestMethod]
        public void PrimePalindrome_of_31880255_is_100030001() =>
            Assert.AreEqual(100030001, Palindrome.GetPrimePalindrome(31880255));
    }
}
