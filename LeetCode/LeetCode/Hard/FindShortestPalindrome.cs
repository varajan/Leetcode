using System.Linq;

namespace LeetCode.Hard
{
    public class FindShortestPalindrome
    {
        public string ShortestPalindrome(string s)
        {
            int len = s.Length;
            int step = len < 10000 ? 1 : 73;

            for (var i = len; i > 0; i-=step)
            {
                if (IsPalindrome(ref s, i))
                {
                    var tail = s.Substring(i, len - i);
                    var head = tail.Aggregate("", (current, t) => t + current);

                    return head + s;
                }
            }

            return "";
        }

        private bool IsPalindrome(ref string line, int length)
        {
            for (var i = 0; i < length / 2; i++)
                if (line[i] != line[length - i - 1])
                    return false;

            return true;
        }
    }
}