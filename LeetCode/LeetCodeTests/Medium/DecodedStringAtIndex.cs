using Microsoft.VisualStudio.TestTools.UnitTesting;
using Decoder = LeetCode.Medium.DecodedStringAtIndex;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class DecodedStringAtIndex
    {
        [TestMethod]
        public void DecodedStringAtIndex_01() =>
            Assert.AreEqual("o", Decoder.DecodeAtIndex("leet2code3", 10));

        [TestMethod]
        public void DecodedStringAtIndex_02() =>
            Assert.AreEqual("e", Decoder.DecodeAtIndex("leet2code3", 15));

        [TestMethod]
        public void DecodedStringAtIndex_03() =>
            Assert.AreEqual("h", Decoder.DecodeAtIndex("ha22", 5));

        [TestMethod]
        public void DecodedStringAtIndex_04() =>
            Assert.AreEqual("a", Decoder.DecodeAtIndex("a2345678999999999999999", 1));

        [TestMethod]
        public void DecodedStringAtIndex_05() =>
            Assert.AreEqual("a", Decoder.DecodeAtIndex("abc", 1));

        [TestMethod]
        public void DecodedStringAtIndex_06() =>
            Assert.AreEqual("a", Decoder.DecodeAtIndex("a23", 6));

        [TestMethod]
        public void DecodedStringAtIndex_07() =>
            Assert.AreEqual("k", Decoder.DecodeAtIndex("vk6u5xhq9v", 554));

        [TestMethod]
        public void DecodedStringAtIndex_08() =>
            Assert.AreEqual("b", Decoder.DecodeAtIndex("a2b3c4d5e6f7g8h9", 3));

        [TestMethod]
        public void DecodedStringAtIndex_09() =>
            Assert.AreEqual("x", Decoder.DecodeAtIndex("ixm5xmgo78", 711));

        [TestMethod]
        public void DecodedStringAtIndex_10() =>
            Assert.AreEqual("q", Decoder.DecodeAtIndex("l3mtm5weq7ki78c7hck4", 1933));

        [TestMethod]
        public void DecodedStringAtIndex_11() =>
            Assert.AreEqual("q", Decoder.DecodeAtIndex("l3mtm5weq7ki78c7hck4", 165511));

        [TestMethod]
        public void DecodedStringAtIndex_12() =>
            Assert.AreEqual("z", Decoder.DecodeAtIndex("vzpp636m8y", 2920));

        [TestMethod]
        public void DecodedStringAtIndex_13() =>
            Assert.AreEqual("a", Decoder.DecodeAtIndex("a4vsb832i3zxouzx6vu6", 31179));

        [TestMethod]
        public void DecodedStringAtIndex_14() =>
            Assert.AreEqual("d", Decoder.DecodeAtIndex("udq827yx7rxjfa4s63h6", 300563));
    }
}