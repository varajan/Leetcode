using System;
using System.Collections.Generic;
using System.Linq;
using Library;

namespace LeetCode.Hard
{
    public static class CrackingSafe
    {
        public static string CrackSafe(int n, int k)
        {
            var codes = k.GenerateAllCombinations(n);
            var combination = "";
            var length = k.Power(n) + (n - 1);

            for (var i = 0; i < length; i++)
            {
                combination += (Math.Min(i, k - 1));
            }

            while (true)
            {
                if (codes.All(code => combination.Contains(code))) return combination;

                combination = combination.Next(k);
            }
        }

        private static string Next(this string combination, int max)
        {
            var overflow = 1;
            var result = string.Empty;

            for (int i = combination.Length - 1; i >= 0; i--)
            {
                var next = (combination[i]-48) + overflow;
                overflow = next >= max ? 1 : 0;
                result = (next >= max ? '0' : (char)(next+48)) + result;
            }

            return result;
        }

        private static string Combine(this string code, string combination)
        {
            var length = Math.Min(code.Length, combination.Length);
            for (; length > 0; length--)
            {
                if (code.Substring(code.Length - length) == combination.Substring(0, length)) break;
            }

            return code + combination.Substring(length);
        }

        public static string InitialCombination(int n, int k, List<string> codes, bool reverse)
        {
            if (reverse) codes.Reverse();
            
            var result = codes.First();

            foreach (var code in codes)
            {
                result += code.Combine(result);
            }

            var length = (int) k.Power(n) + (n - 1);
            
            return result.Substring(result.Length-length, length);
        }
    }
}
