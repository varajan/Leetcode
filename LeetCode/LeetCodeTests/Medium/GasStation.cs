using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class GasStation
    {
        private static LeetCode.Medium.GasStation Trip => new LeetCode.Medium.GasStation();

        [TestMethod]
        public void GasStation_01()
        {
            var gas = new [] { 1, 2, 3, 4, 5 };
            var cost = new [] { 3, 4, 5, 1, 2 };

            Assert.AreEqual(3, Trip.CanCompleteCircuit(gas, cost));
        }
    }
}