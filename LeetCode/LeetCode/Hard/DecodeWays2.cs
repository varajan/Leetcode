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
                result = Medium.DecodeWays.GetRoots(code);
            }
            else
            {
                for (var i = '1'; i < ':'; i++)
                {
                    code[index] = i;
                    result += GetRoots2(code);
                }
                code[index] = '*';
            }

            return result;
        }
    }
}