using Microsoft.VisualStudio.TestTools.UnitTesting;
using Decoder = LeetCode.Medium.DecodedStringAtIndex;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class DecodedStringAtIndex
    {
        [TestMethod]
        public void DecodedStringAtIndex_01_leet2code3_10th_is_o() =>
            Assert.AreEqual("o", Decoder.DecodeAtIndex("leet2code3", 10));

        [TestMethod]
        public void DecodedStringAtIndex_02_leet2code3_15th_is_e() =>
            Assert.AreEqual("e", Decoder.DecodeAtIndex("leet2code3", 15));

        [TestMethod]
        public void DecodedStringAtIndex_03_ha22_5th_is_h() =>
            Assert.AreEqual("h", Decoder.DecodeAtIndex("ha22", 5));

        [TestMethod]
        public void DecodedStringAtIndex_04_a2345678999999999999999_1st_is_a() =>
            Assert.AreEqual("a", Decoder.DecodeAtIndex("a2345678999999999999999", 1));

        [TestMethod]
        public void DecodedStringAtIndex_05_abc_1st_is_a() =>
            Assert.AreEqual("a", Decoder.DecodeAtIndex("abc", 1));

        [TestMethod]
        public void DecodedStringAtIndex_05_abc_3rd_is_c() =>
            Assert.AreEqual("c", Decoder.DecodeAtIndex("abc", 3));

        [TestMethod]
        public void DecodedStringAtIndex_06_a23_6th_is_a() =>
            Assert.AreEqual("a", Decoder.DecodeAtIndex("a23", 6));

        [TestMethod]
        public void DecodedStringAtIndex_07_vk6u5xhq9v_554th_is_k() =>
            Assert.AreEqual("k", Decoder.DecodeAtIndex("vk6u5xhq9v", 554));

        [TestMethod]
        public void DecodedStringAtIndex_08_a2b3c4d5e6f7g8h9_9th_is_b() =>
            Assert.AreEqual("b", Decoder.DecodeAtIndex("a2b3c4d5e6f7g8h9", 9));

        [TestMethod]
        public void DecodedStringAtIndex_09_a2b3c4d5e6f7g8h9_10th_is_c() =>
            Assert.AreEqual("c", Decoder.DecodeAtIndex("a2b3c4d5e6f7g8h9", 10));

        [TestMethod]
        public void DecodedStringAtIndex_10_a2b3c4d5e6f7g8h9_623529th_is_h() =>
            Assert.AreEqual("h", Decoder.DecodeAtIndex("a2b3c4d5e6f7g8h9", 623529));

        [TestMethod]
        public void DecodedStringAtIndex_11_ixm5xmgo78_711th_is_x() =>
            Assert.AreEqual("x", Decoder.DecodeAtIndex("ixm5xmgo78", 711));

        [TestMethod]
        public void DecodedStringAtIndex_12_l3mtm5weq7ki78c7hck4_1933rd_is_l() =>
            Assert.AreEqual("l", Decoder.DecodeAtIndex("l3mtm5weq7ki78c7hck4", 1933));

        [TestMethod]
        public void DecodedStringAtIndex_13_l3mtm5weq7ki78c7hck4_165511th_is_l() =>
            Assert.AreEqual("l", Decoder.DecodeAtIndex("l3mtm5weq7ki78c7hck4", 165511));

        [TestMethod]
        public void DecodedStringAtIndex_14_vzpp636m8y_2920th_is_p() =>
            Assert.AreEqual("p", Decoder.DecodeAtIndex("vzpp636m8y", 2920));

        [TestMethod]
        public void DecodedStringAtIndex_15_a4vsb832i3zxouzx6vu6_31179th_is_a() =>
            Assert.AreEqual("a", Decoder.DecodeAtIndex("a4vsb832i3zxouzx6vu6", 31179));

        [TestMethod]
        public void DecodedStringAtIndex_16_udq827yx7rxjfa4s63h6_300563rd_is_u() =>
            Assert.AreEqual("u", Decoder.DecodeAtIndex("udq827yx7rxjfa4s63h6", 300563));

        [TestMethod]
        public void DecodedStringAtIndex_17_y959q969u3hb22odq595_300563rd_is_y() =>
            Assert.AreEqual("y", Decoder.DecodeAtIndex("y959q969u3hb22odq595", 222280369));

        [TestMethod]
        public void DecodedStringAtIndex_18_yl3mtm5weq7ki78c7hck4_165511th_is_l() =>
            Assert.AreEqual("l", Decoder.DecodeAtIndex("l3mtm5weq7ki78c7hck4", 165511));

        [TestMethod]
        public void DecodedStringAtIndex_19_udq827yx7rxjfa4s63h6_300563rd_is_u() =>
            Assert.AreEqual("u", Decoder.DecodeAtIndex("udq827yx7rxjfa4s63h6", 300563));

        [TestMethod]
        public void DecodedStringAtIndex_20_ab2c3de4()
        {
            var decodedString = "ababcababcababcdeababcababcababcdeababcababcababcdeababcababcababcdef";

            for (var i = 0; i < decodedString.Length; i++)
            {
                Assert.AreEqual(decodedString[i].ToString(), Decoder.DecodeAtIndex("ab2c3de4f", i+1), $"i={i}");
            }
        }

        [TestMethod]
        public void DecodedStringAtIndex_21_vzpp636m8y()
        {
            var decodedString = "";
            var code = string.Empty;
            for (var x = 0; x < 636; x++) code += decodedString + "vzpp"; decodedString = code; code = string.Empty;
            for (var x = 0; x < 8; x++) code += decodedString + "m"; decodedString = code; code = string.Empty;
            for (var x = 0; x < 1; x++) code += decodedString + "y"; decodedString = code; code = string.Empty;

            for (var i = 0; i < decodedString.Length; i++)
            {
                Assert.AreEqual(decodedString[i].ToString(), Decoder.DecodeAtIndex("vzpp636m8y", i+1), $"i={i}");
            }
        }
    }
}