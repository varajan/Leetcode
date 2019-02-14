using System.Linq;
using Library;

namespace LeetCode.Hard
{
    public static class CrackingSafe
    {
        public static string CrackSafe(int n, int k)
        {
            // n - length
            var codes = k.GenerateAllCombinations(n);

            codes.Reverse();

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
