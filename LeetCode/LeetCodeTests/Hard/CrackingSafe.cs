using Microsoft.VisualStudio.TestTools.UnitTesting;
using Crack = LeetCode.Hard.CrackingSafe;

namespace LeetCodeTests.Hard
{
    [TestClass]
    public class CrackingSafe
    {
        [TestMethod]
        public void CrackingSafe_01() => Assert.AreEqual("01", Crack.CrackSafe(1, 2));

        [TestMethod]
        public void CrackingSafe_02() => Assert.AreEqual("00110", Crack.CrackSafe(2, 2));

        [TestMethod]
        public void CrackingSafe_03() => Assert.AreEqual("0011101000", Crack.CrackSafe(3, 2));


        private void VerifyCrack(string code, string expectedLength, string n, string k)
        {
//var codes = 
        }
    }
}
