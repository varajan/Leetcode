using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class MaskingPersonalInformation
    {
        private static LeetCode.Medium.MaskingPersonalInformation Masking =>
            new LeetCode.Medium.MaskingPersonalInformation();

        [TestMethod]
        public void MaskingPersonalInformation_01()
        {
            Assert.AreEqual("l*****e@leetcode.com", Masking.MaskPII("LeetCode@LeetCode.com"));
        }

        [TestMethod]
        public void MaskingPersonalInformation_02()
        {
            Assert.AreEqual("a*****b@qq.com", Masking.MaskPII("AB@qq.com"));
        }

        [TestMethod]
        public void MaskingPersonalInformation_03()
        {
            Assert.AreEqual("***-***-7890", Masking.MaskPII("1(234)567-890"));
        }

        [TestMethod]
        public void MaskingPersonalInformation_04()
        {
            Assert.AreEqual("+**-***-***-5678", Masking.MaskPII("86-(10)12345678"));
        }

        [TestMethod]
        public void MaskingPersonalInformation_05()
        {
            Assert.AreEqual("+***-***-***-3431", Masking.MaskPII("+(501321)-50-23431"));
        }
    }
}