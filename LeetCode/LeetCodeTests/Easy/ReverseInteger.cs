using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reverse = LeetCode.Easy.ReverseInteger;

namespace LeetCodeTests.Easy
{
    [TestClass]
    public class ReverseInteger
    {
        [TestMethod]
        public void ReverseInteger_01_Positive_number() => Assert.AreEqual(321, Reverse.Reverse(123));

        [TestMethod]
        public void ReverseInteger_02_Negative_number() => Assert.AreEqual(-321, Reverse.Reverse(-123));

        [TestMethod]
        public void ReverseInteger_03_Number_ends_with_zeros() => Assert.AreEqual(321, Reverse.Reverse(12300));

        [TestMethod]
        public void ReverseInteger_04_Number_contains_zeros() => Assert.AreEqual(30201, Reverse.Reverse(10203));

        [TestMethod]
        public void ReverseInteger_05_Result_overflows_for_positive_number() => Assert.AreEqual(0, Reverse.Reverse(int.MaxValue));

        [TestMethod]
        public void ReverseInteger_06_Result_overflows_for_negative_number() => Assert.AreEqual(0, Reverse.Reverse(int.MinValue));
   }
}