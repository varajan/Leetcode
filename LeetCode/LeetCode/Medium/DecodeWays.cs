using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    public static class DecodeWays
    {
        public static int NumDecodings(string s)
        {
            var roots = GetRoots(s, new List<List<int>> {new List<int>()});
            return roots.Count(root => root.Any());
        }

        private static List<List<int>> GetRoots(string code, List<List<int>> roots)
        {
            var roots1 = new List<List<int>>();
            var roots2 = new List<List<int>>();

            if (code.Length == 0)
            {
                return roots;
            }

            if (code.Length > 1 && GetCode(code, 2) < 27 && GetCode(code) > 0)
            {
                var x = GetCode(code, 2);

                foreach (var root in roots)
                {
                    roots1.Add(new List<int>(root) { x });
                }

                roots1 = GetRoots(code.Substring(2, code.Length - 2), roots1);
            }
            if (GetCode(code) > 0)
            {
                var x = GetCode(code, 1);

                foreach (var root in roots)
                {
                    roots2.Add(new List<int>(root) { x });
                }

                roots2 = GetRoots(code.Substring(1, code.Length - 1), roots2);
            }

            roots1.AddRange(roots2);
            return roots1;
        }

        private static int GetCode(string code, int length = 1)
        {
            return int.Parse(code.Substring(0, length));
        }
    }
}