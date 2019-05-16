using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Hard
{
    [TestClass]
    public class IntegerToEnglishWords
    {
        private LeetCode.Hard.IntegerToEnglishWords Converter => new LeetCode.Hard.IntegerToEnglishWords();

        [TestMethod]
        public void IntegerToEnglishWords_0() =>
            Assert.AreEqual("Zero", Converter.NumberToWords(0));

        [TestMethod]
        public void IntegerToEnglishWords_123() =>
            Assert.AreEqual("One Hundred Twenty Three", Converter.NumberToWords(123));

        [TestMethod]
        public void IntegerToEnglishWords_12345() =>
            Assert.AreEqual("Twelve Thousand Three Hundred Forty Five", Converter.NumberToWords(12345));

        [TestMethod]
        public void IntegerToEnglishWords_1000000() =>
            Assert.AreEqual("One Million",
                Converter.NumberToWords(1000000));

        [TestMethod]
        public void IntegerToEnglishWords_1234567() =>
            Assert.AreEqual("One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven",
                Converter.NumberToWords(1234567));

        [TestMethod]
        public void IntegerToEnglishWords_1234567891() =>
            Assert.AreEqual("One Billion Two Hundred Thirty Four Million Five Hundred Sixty Seven Thousand Eight Hundred Ninety One",
                Converter.NumberToWords(1234567891));
    }
}