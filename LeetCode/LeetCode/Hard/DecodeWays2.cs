using System.Collections.Generic;

namespace LeetCode.Hard
{
    public static class DecodeWays2
    {
        public static int NumDecodings(string s)
        {
            var indexes = new List<short>();
            short i = -1;
            foreach (var x in s)
            {
                i++;
                if (x=='*') indexes.Add(i);
            }

            return GetRoots(s.ToCharArray(), indexes.ToArray());
        }

        private static int GetRoots(char[] code, short[] indexes, int ii = 0)
        {
            if (ii >= indexes.Length)
            {
                return Medium.DecodeWays.GetRoots(code);
            }

            var result = 0;
            var next = ii + 1;
            var index = indexes[ii];
            for (var i = '1'; i < ':'; i++)
            {
                code[index] = i;
                result += GetRoots(code, indexes, next);
            }
            code[index] = '*';

            return result;
        }
    }
}