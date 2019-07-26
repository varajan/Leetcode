using System.Collections.Generic;
using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Hard
{
    [TestClass]
    public class TextJustification
    {
        private LeetCode.Hard.TextJustification Text => new LeetCode.Hard.TextJustification();

        [TestMethod]
        public void TextJustification_01()
        {
            var words = new[] {"This", "is", "an", "example", "of", "text", "justification."};
            var actual = Text.FullJustify(words, 16);
            var expected = new List<string>
            {
                "This    is    an",
                "example  of text",
                "justification.  "
            };

            ListExtensions<string>.ShouldEqual(actual, expected);
        }

        [TestMethod]
        public void TextJustification_02()
        {
            var words = new[] { "My", "momma", "always", "said,", "\"Life", "was", "like", "a", "box", "of", "chocolates.", "You", "never", "know", "what", "you're", "gonna", "get." };
            var actual = Text.FullJustify(words, 20);
            var expected = new List<string>
            {
                "My    momma   always",
                "said, \"Life was like",
                "a box of chocolates.",
                "You  never know what",
                "you're gonna get.   "
            };

            ListExtensions<string>.ShouldEqual(actual, expected);
        }
    }
}