using Microsoft.VisualStudio.TestTools.UnitTesting;
using Crack = LeetCode.Hard.CrackingSafe;
using Library;

namespace LeetCodeTests.Hard
{
    [TestClass]
    public class CrackingSafe
    {
        [TestMethod]
        public void CrackingSafe_01_n_is_1_and_k_is_2() => VerifyCrack(1, 2, 2);

        [TestMethod]
        public void CrackingSafe_02_n_is_2_and_k_is_2() => VerifyCrack(2, 2, 6);

        [TestMethod]
        public void CrackingSafe_03_n_is_3_and_k_is_2() => VerifyCrack(3, 2, 9);


        private static void VerifyCrack(int n, int k, int expectedLength)
        {
            var code = Crack.CrackSafe(n, k);
            Assert.AreEqual(expectedLength, code.Length, $"'{code}' code length doesn't equal to expected value.");

            var codes = k.GenerateAllCombinations(n);
            codes.ForEach(combination => Assert.IsTrue(code.Contains(combination),
                $"Code {combination} is not covered."));
        }
    }
}
