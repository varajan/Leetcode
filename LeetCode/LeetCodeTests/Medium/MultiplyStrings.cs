using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class MultiplyStrings
    {
        private LeetCode.Medium.MultiplyStrings Strings => new LeetCode.Medium.MultiplyStrings();

        [TestMethod]
        public void MultiplyStrings_2_3() =>
            Assert.AreEqual("6", Strings.Multiply("2", "3"));

        [TestMethod]
        public void MultiplyStrings_123_456() =>
            Assert.AreEqual("56088", Strings.Multiply("123", "456"));

        [TestMethod]
        public void MultiplyStrings_123456789_987654321() =>
            Assert.AreEqual("121932631112635269", Strings.Multiply("123456789", "987654321"));

        [TestMethod]
        public void MultiplyStrings_123456789_0() =>
            Assert.AreEqual("0", Strings.Multiply("123456789", "0"));

        [Timeout(15)]
        [TestMethod]
        public void MultiplyStrings_398952156347820415337010868272413429836462364637363164372310573115219077216899627() =>
            Assert.AreEqual("22227597896747931974032471411465102311462678900848060110229065542539766699641722110846910736641448270255228166899577189463",
                Strings.Multiply(
                "55714946123437258158091870754660433857669",
                "398952156347820415337010868272413429836462364637363164372310573115219077216899627"));

        [Timeout(10)]
        [TestMethod]
        public void MultiplyStrings_9369162965141127216164882458728854782080715827760307787224298083754() =>
            Assert.AreEqual("67500649338953014190022427720009974152122888684303491539825680400401937831201855940252",
                Strings.Multiply(
                "9369162965141127216164882458728854782080715827760307787224298083754",
                "7204554941577564438"));
    }
}