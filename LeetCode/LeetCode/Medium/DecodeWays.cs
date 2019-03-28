namespace LeetCode.Medium
{
    public static class DecodeWays
    {
        public static int NumDecodings(string s)
        {
            return GetRoots(s.ToCharArray());
        }

        public static int GetRoots(char[] code, int i = 0, int roots = 0)
        {
            if (code.Length == i)
            {
                return roots;
            }

            if (code[i] == 48) return 0;

            int roots1 = GetRoots(code, i + 1, 1);
            int roots2 = 0;

            if (code.Length > i+1 && (code[i]==49 || code[i]==50 && code[i+1] < 55))
            {
                roots2 = GetRoots(code, i + 2, 1);
            }

            return roots1 + roots2;
        }
    }
}