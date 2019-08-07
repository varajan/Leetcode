using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class Car_Fleet
    {
        private static LeetCode.Medium.Car_Fleet Fleet => new LeetCode.Medium.Car_Fleet();

        [TestMethod]
        public void Car_Fleet_01()
        {
            var target = 12;
            var position = new[] {10, 8, 0, 5, 3};
            var speed = new[] {2, 4, 1, 1, 3};

            Assert.AreEqual(3, Fleet.CarFleet(target, position, speed));
        }

        [TestMethod]
        public void Car_Fleet_02()
        {
            var target = 16;
            var position = new[] {11, 14, 13, 6};
            var speed = new[] {2, 2, 6, 7};

            Assert.AreEqual(2, Fleet.CarFleet(target, position, speed));
        }

        [TestMethod]
        public void Car_Fleet_03()
        {
            var target = 10;
            var position = new[] {6, 8};
            var speed = new[] {3, 2};

            Assert.AreEqual(2, Fleet.CarFleet(target, position, speed));
        }

        [TestMethod]
        public void Car_Fleet_04()
        {
            var target = 13;
            var position = new[] {10, 2, 5, 7, 4, 6, 11};
            var speed = new[] {7, 5, 10, 5, 9, 4, 1};

            Assert.AreEqual(2, Fleet.CarFleet(target, position, speed));
        }

        [TestMethod]
        public void Car_Fleet_05()
        {
            var target = 31;
            var position = new[] {5, 26, 18, 25, 29, 21, 22, 12, 19, 6};
            var speed = new[] {7, 6, 6, 4, 3, 4, 9, 7, 6, 4};

            Assert.AreEqual(6, Fleet.CarFleet(target, position, speed));
        }
    }
}