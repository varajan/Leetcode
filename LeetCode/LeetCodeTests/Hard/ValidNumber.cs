using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Hard
{
    [TestClass]
    public class ValidNumber
    {
        private LeetCode.Hard.ValidNumber Validator => new LeetCode.Hard.ValidNumber();

        [TestMethod]
        public void ValidNumber_space() => Assert.IsFalse(Validator.IsNumber("  "));

        [TestMethod]
        public void ValidNumber_0() => Assert.IsTrue(Validator.IsNumber("0"));

        [TestMethod]
        public void ValidNumber_dot_1() => Assert.IsTrue(Validator.IsNumber(".1"));

        [TestMethod]
        public void ValidNumber_1_dot() => Assert.IsTrue(Validator.IsNumber("1."));

        [TestMethod]
        public void ValidNumber_dot() => Assert.IsFalse(Validator.IsNumber("."));

        [TestMethod]
        public void ValidNumber_0_1() => Assert.IsTrue(Validator.IsNumber("0.1"));

        [TestMethod]
        public void ValidNumber_2e10() => Assert.IsTrue(Validator.IsNumber("2e10"));

        [TestMethod]
        public void ValidNumber_minus_dot() => Assert.IsFalse(Validator.IsNumber(" -.  "));

        [TestMethod]
        public void ValidNumber_minus90e3() => Assert.IsTrue(Validator.IsNumber(" -90e3   "));

        [TestMethod]
        public void ValidNumber_6e_minus1() => Assert.IsTrue(Validator.IsNumber(" 6e-1"));

        [TestMethod]
        public void ValidNumber_e_10() => Assert.IsFalse(Validator.IsNumber(" e10"));

        [TestMethod]
        public void ValidNumber_53dot5e93() => Assert.IsTrue(Validator.IsNumber("53.5e93"));

        [TestMethod]
        public void ValidNumber_minus_1_dot() => Assert.IsTrue(Validator.IsNumber("-1."));

        [TestMethod]
        public void ValidNumber_plus_1_dot() => Assert.IsTrue(Validator.IsNumber("+1."));

        [TestMethod]
        public void ValidNumber_minus_minus6() => Assert.IsFalse(Validator.IsNumber(" --6 "));

        [TestMethod]
        public void ValidNumber_minus_plus6() => Assert.IsFalse(Validator.IsNumber(" -+6 "));

        [TestMethod]
        public void ValidNumber_99e2dot5() => Assert.IsFalse(Validator.IsNumber(" 99e2.5 "));

        [TestMethod]
        public void ValidNumber_99dot_e2() => Assert.IsTrue(Validator.IsNumber(" 99.e2 "));

        [TestMethod]
        public void ValidNumber_95a54e53() => Assert.IsFalse(Validator.IsNumber("95a54e53"));

        [TestMethod]
        public void ValidNumber_005047e_plus_6() => Assert.IsTrue(Validator.IsNumber(" 005047e+6"));

        [TestMethod]
        public void ValidNumber_1e() => Assert.IsFalse(Validator.IsNumber("1e"));

        [TestMethod]
        public void ValidNumber_e3() => Assert.IsFalse(Validator.IsNumber("e3"));

        [TestMethod]
        public void ValidNumber_dot_e3() => Assert.IsFalse(Validator.IsNumber(".e3"));

        [TestMethod]
        public void ValidNumber_abc() => Assert.IsFalse(Validator.IsNumber("abc"));

        [TestMethod]
        public void ValidNumber_1a() => Assert.IsFalse(Validator.IsNumber("1 a"));
    }
}