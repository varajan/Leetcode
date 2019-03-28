using System;

namespace LeetCode.Hard
{
    public static class DecodeWays2
    {
        public static int NumDecodings(string s)
        {
            return GetRoots2(s.ToCharArray());
        }

        private static int GetRoots2(char[] code)
        {
            var result = 0;
            var index = Array.IndexOf(code, '*');

            if (index < 0)
            {
                result = GetRoots(code);
            }
            else
            {
                for (var i = '1'; i < ':'; i++)
                {
                    code[index] = i;
                    result += GetRoots2(code);
                    code[index] = '*';
                }
            }

            return result;
        }

        private static int GetRoots(char[] code, int i = 0, int roots = 0)
        {
            if (code.Length == i)
            {
                return roots;
            }

            if (code[i] == 48) return 0;

            int roots1 = GetRoots(code, i + 1, 1);
            int roots2 = 0;

            if (code.Length > i + 1 && (code[i] == 49 || code[i] == 50 && code[i + 1] < 55))
            {
                roots2 = GetRoots(code, i + 2, 1);
            }

            return roots1 + roots2;
        }
    }
}
