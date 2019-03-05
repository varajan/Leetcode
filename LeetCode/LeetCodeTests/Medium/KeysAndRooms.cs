using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Keys = LeetCode.Medium.KeysAndRooms;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class KeysAndRooms
    {
        [TestMethod]
        public void KeysAndRooms_01()
        {
            var rooms = new List<IList<int>>
            {
                new List<int> {1},
                new List<int> {2},
                new List<int> {3},
                new List<int> {}
            };

            Assert.IsTrue(Keys.CanVisitAllRooms(rooms));
        }

        [TestMethod]
        public void KeysAndRooms_02()
        {
            var rooms = new List<IList<int>>
            {
                new List<int> {1, 3},
                new List<int> {3, 0, 1},
                new List<int> {2},
                new List<int> {0}
            };

            Assert.IsFalse(Keys.CanVisitAllRooms(rooms));
        }
    }
}
