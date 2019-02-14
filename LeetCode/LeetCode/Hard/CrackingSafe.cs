using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LeetCode.Hard
{
    public static class CrackingSafe
    {
        public static string CrackSafe(int n, int k)
        {
            // n - length
            var codes = k.GenerateAllCombinations(n);

            var result = string.Empty;

            while (codes.Count > 0)
            {
                //var indexes = new List<int>();
                //for (var i = 0; i < codes.Count; i++)
                //{
                //    if (result.Contains(codes[i]))
                //    {
                //        indexes.Add(i);
                //    }
                //}

                //indexes
                //    .OrderByDescending(index => index).ToList()
                //    .ForEach(index => codes.RemoveAt(index));

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
                        if (result.StartsWith(code.Substring(length)))
                        {
                            result = code.Substring(0, length) + result;
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
