namespace LeetCode.Medium
{
    public class LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            int resultStart = 0;
            int resultLength = 0;

            for (int start = 0; start < s.Length; start++)
            {
                for (int length = (s.Length - start); resultLength < length; length--)
                {
                    if (!IsPalindrome(ref s, ref start, ref length)) continue;

                    resultStart = start;
                    resultLength = length;
                }
            }

            return s.Substring(resultStart, resultLength);
        }

        private static bool IsPalindrome(ref string s, ref int start, ref int length)
        {
            int offset = (length - 1 + start);
            for (var i = 0; i < length / 2; i++)
                if (s[i + start] != s[offset - i]) return false;

            return true;
        }
    }
}