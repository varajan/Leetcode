namespace LeetCode.Medium
{
    public static class DecodeWays
    {
        public static int NumDecodings(string s)
        {
            return GetRoots(s, 0);
        }

        private static int GetRoots(string code, int roots)
        {
            if (code.Length == 0)
            {
                return roots;
            }

            bool notNull = code[0] > 48;
            int roots1 = 0;
            int roots2 = 0;

            if (code.Length > 1 && (code[0]==49 || code[0]==50 && code[1] < 55) && notNull)
            {
                roots1 = GetRoots(code.Substring(2, code.Length - 2), roots1 == 0 ? 1 : roots1);
            }
            if (notNull)
            {
                roots2 = GetRoots(code.Substring(1, code.Length - 1), roots2 == 0 ? 1 : roots2);
            }

            return roots1 + roots2;
        }

        private static int GetCode(string code) => (code[0] - 48) * 10 + code[1] - 48;
    }
}