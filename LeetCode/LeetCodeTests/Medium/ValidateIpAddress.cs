using Microsoft.VisualStudio.TestTools.UnitTesting;
using Validator = LeetCode.Medium.ValidateIpAddress;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class ValidateIpAddress
    {
        [TestMethod]
        public void ValidateIpAddress_01() =>
            Assert.AreEqual("IPv4", Validator.ValidateAddress("172.16.254.1"));

        [TestMethod]
        public void ValidateIpAddress_02() =>
            Assert.AreEqual("Neither", Validator.ValidateAddress("172.516.254.1"));

        [TestMethod]
        public void ValidateIpAddress_03() =>
            Assert.AreEqual("Neither", Validator.ValidateAddress("1e1.4.5.6"));

        [TestMethod]
        public void ValidateIpAddress_04() =>
            Assert.AreEqual("IPv6", Validator.ValidateAddress("2001:0db8:85a3:0:0:8A2E:0370:7334"));

        [TestMethod]
        public void ValidateIpAddress_05() =>
            Assert.AreEqual("Neither", Validator.ValidateAddress("01.01.01.01"));

        [TestMethod]
        public void ValidateIpAddress_06() =>
            Assert.AreEqual("Neither", Validator.ValidateAddress("20EE:FGb8:85a3:0:0:8A2E:0370:7334"));

        [TestMethod]
        public void ValidateIpAddress_07() =>
            Assert.AreEqual("IPv4", Validator.ValidateAddress("192.0.0.1"));

        [TestMethod]
        public void ValidateIpAddress_08() =>
            Assert.AreEqual("Neither", Validator.ValidateAddress("00.0.0.0"));
    }
}