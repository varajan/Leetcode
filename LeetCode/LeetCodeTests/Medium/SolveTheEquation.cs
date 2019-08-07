using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class SolveTheEquation
    {
        private static LeetCode.Medium.SolveTheEquation Equation => new LeetCode.Medium.SolveTheEquation();

        [TestMethod]
        public void SolveTheEquation_01() => Assert.AreEqual("x=2", Equation.SolveEquation("x+5-3+x=6+x-2"));

        [TestMethod]
        public void SolveTheEquation_02() => Assert.AreEqual("x=-1", Equation.SolveEquation("2x+3x-6x=x+2"));

        [TestMethod]
        public void SolveTheEquation_03() => Assert.AreEqual("Infinite solutions", Equation.SolveEquation("x=x"));

        [TestMethod]
        public void SolveTheEquation_04() => Assert.AreEqual("No solution", Equation.SolveEquation("x=x+2"));

        [TestMethod]
        public void SolveTheEquation_05() => Assert.AreEqual("x=1", Equation.SolveEquation("-x=-1"));
    }
}