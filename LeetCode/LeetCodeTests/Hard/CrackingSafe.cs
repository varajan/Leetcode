using Microsoft.VisualStudio.TestTools.UnitTesting;
using Crack = LeetCode.Hard.CrackingSafe;
using Library;

namespace LeetCodeTests.Hard
{
    [TestClass]
    public class CrackingSafe
    {
        [Timeout(10000)]
        [TestMethod]
        public void CrackingSafe_01_n_is_1_and_k_is_2() => VerifyCrack(1, 2, 2);

        [Timeout(10000)]
        [TestMethod]
        public void CrackingSafe_02_n_is_2_and_k_is_2() => VerifyCrack(2, 2, 5);

        [Timeout(10000)]
        [TestMethod]
        public void CrackingSafe_03_n_is_3_and_k_is_2() => VerifyCrack(3, 2, 10);

        [Timeout(10000)]
        [TestMethod]
        public void CrackingSafe_04_n_is_1_and_k_is_9() => VerifyCrack(1, 9, 9);

        [Timeout(10000)]
        [TestMethod]
        public void CrackingSafe_05_n_is_2_and_k_is_3() => VerifyCrack(2, 3, 10);

        [Timeout(10000)]
        [TestMethod]
        public void CrackingSafe_06_n_is_2_and_k_is_4() => VerifyCrack(2, 4, 17);

        [Timeout(10000)]
        [TestMethod]
        public void CrackingSafe_07_n_is_2_and_k_is_1() => VerifyCrack(2, 1, 2);

        [Timeout(10000)]
        [TestMethod]
        public void CrackingSafe_08_n_is_2_and_k_is_1() => Assert.AreEqual("00", Crack.CrackSafe(2, 1));

        [Timeout(10000)]
        [TestMethod]
        public void CrackingSafe_09_n_is_2_and_k_is_2() => VerifyCrack(2, 2, 5);

        [Timeout(30000)]
        [TestMethod]
        public void CrackingSafe_10_n_is_2_and_k_is_9() => VerifyCrack(2, 9, 82);


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
