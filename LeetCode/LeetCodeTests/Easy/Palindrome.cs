using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromer = LeetCode.Easy.Palindrome;

namespace LeetCodeTests.Easy
{
    [TestClass]
    public class Palindrome
    {
        [TestMethod]
        public void Palindrome_01_Nothing_to_remove_to_get_palindrome() => Assert.AreEqual(true, Palindromer.Validate2("abcba"));

        [TestMethod]
        public void Palindrome_02_One_char_to_remove_to_get_palindrome() => Assert.AreEqual(true, Palindromer.Validate2("abcbba"));

        [TestMethod]
        public void Palindrome_03_Two_chars_to_remove_to_get_palindrome() => Assert.AreEqual(false, Palindromer.Validate2("abdacbba"));

        [TestMethod]
        public void Palindrome_04_Empty_string_is_not_a_palindrome() => Assert.AreEqual(false, Palindromer.Validate2(string.Empty));

        [TestMethod]
        public void Palindrome_05_Not_a_palindrome() => Assert.AreEqual(false, Palindromer.Validate2("abcdefghjklmn"));
    }
}