using Microsoft.VisualStudio.TestTools.UnitTesting;
using String2Int = LeetCode.Medium.StringToInt_ATOI;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class StringToInt_ATOI
    {
        [TestMethod]
        public void StringToInt_ATOI_01_asdf_123_is_0() => Assert.AreEqual(0, String2Int.MyAtoi("asdf 123"));

        [TestMethod]
        public void StringToInt_ATOI_02_42_is_42() => Assert.AreEqual(42, String2Int.MyAtoi("42"));

        [TestMethod]
        public void StringToInt_ATOI_03_minus_42_is_minus_42() => Assert.AreEqual(-42, String2Int.MyAtoi("-42"));

        [TestMethod]
        public void StringToInt_ATOI_04_2147483648_is_2147483647() => Assert.AreEqual(2147483647, String2Int.MyAtoi("2147483648"));

        [TestMethod]
        public void StringToInt_ATOI_05_minus_2147483650_is_minus_2147483648() => Assert.AreEqual(-2147483648, String2Int.MyAtoi("-2147483650"));
    }
}