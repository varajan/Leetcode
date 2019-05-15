using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class CostomStringSorting
    {
        private LeetCode.Medium.CostomStringSorting Sorting => new LeetCode.Medium.CostomStringSorting();

        [TestMethod]
        public void CostomStringSorting_01() => Assert.AreEqual("cdba", Sorting.CustomSortString("cba", "abcd"));

        [TestMethod]
        public void CostomStringSorting_02() => Assert.AreEqual("eevxw", Sorting.CustomSortString("exw", "xwvee"));
    }
}