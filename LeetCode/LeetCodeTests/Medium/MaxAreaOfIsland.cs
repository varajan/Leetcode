using Microsoft.VisualStudio.TestTools.UnitTesting;
using Island = LeetCode.Medium.MaxAreaOfIsland;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class MaxAreaOfIsland
    {
        [TestMethod]
        public void MaxAreaOfIsland_01() =>
            Assert.AreEqual(0, Island.AreaOfIsland( new [,] {{ 0, 0, 0, 0, 0, 0, 0, 0 } }));

        [TestMethod]
        public void MaxAreaOfIsland_02()
        {
            var map = new int[,]
            {
                {0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                {0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0},
                {0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0}
            };

            Assert.AreEqual(6, Island.AreaOfIsland(map));
        }

        [TestMethod]
        public void MaxAreaOfIsland_03() =>
            Assert.AreEqual(2, Island.AreaOfIsland(new[,] { { 1, 1 } }));
    }
}