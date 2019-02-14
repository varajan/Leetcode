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
            var length = k.Power(n) + (n - 1);
            var codes = k.GenerateAllCombinations(n);
            var result = CrackSafe2(n, k, codes.ToList());

            foreach (var combination in MathExtensions.GenerateCombinations(codes.Count))
            {
                if (result.Length == length)
                {
                    break;
                }

                result = string.Empty;
                foreach (var i in combination)
                {
                    result = result.Combine(codes[i]);

                    if (result.Length > length) break;
                }
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

        public static string CrackSafe2(int n, int k, List<string> codes)
        {
            //var codes = k.GenerateAllCombinations(n);
            codes.Reverse();
            var result = string.Empty;
 
            while (codes.Count > 0)
            {
                foreach (var code in codes)
                {
                    var found = false;

                    if (result.Contains(code))
                    {
                        codes.Remove(code);
                        break;
                    }

                    for (var length = n-1; length > 0; length--)
                    {
                        if (result.StartsWith(code.Substring(length-1)))
                        {
                            result = code.Substring(0, length-1) + result;
                            codes.Remove(code);
                            found = true;
                            break;
                        }

                        if (result.EndsWith(code.Substring(0, length)))
                        {
                            result += code.Substring(length);
                            codes.Remove(code);
                            found = true;
                            break;
                        }
                    }

                    if (found) break;

                    if (codes.Any())
                    {
                        result += codes.First();
                        codes.Remove(codes.First());
                        break;
                    }
                }
            }

            return result;
        }
    }
}
