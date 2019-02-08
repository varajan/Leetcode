using Microsoft.VisualStudio.TestTools.UnitTesting;
using Container = LeetCode.Medium.ContainerWithMostWater;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class ContainerWithMostWater
    {
        [TestMethod]
        public void ContainerWithMostWater_01() => Assert.AreEqual(0, Container.MaxArea(new int[]{}));

        [TestMethod]
        public void ContainerWithMostWater_02() => Assert.AreEqual(49, Container.MaxArea(new int[] {1, 8, 6, 2, 5, 4, 8, 3, 7}));
    }
}
