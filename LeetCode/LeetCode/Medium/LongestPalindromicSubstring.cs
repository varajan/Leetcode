namespace LeetCode.Medium
{
    public class LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            int sLength = s.Length;
            for (int length = sLength; length > 0; length--)
            {
                for (int i = 0; i <= sLength - length; i++)
                {
                    if (IsPalindrome(s, i, length))
                    {
                        return s.Substring(i, length);
                    }
                }
            }

            return s;
        }

        private static bool IsPalindrome(string s, int start, int length)
        {
            int offset = (length - 1 + start);
            for (var i = 0; i < length / 2; i++)
                if (s[i + start] != s[offset - i]) return false;

            return true;
        }
    }
}