using System.Collections.Generic;

namespace LeetCode.Hard
{
    public class PalindromePairsSearcher
    {
        public List<List<int>> PalindromePairs(string[] words)
        {
            var result = new List<List<int>>();

            for (var i = 0; i < words.Length-1; i++)
            for (var j = i+1; j < words.Length; j++)
            {
                if (i == j) continue;

                if (IsPalindrome(ref words[i], ref words[j]))
                    result.Add(new List<int> { i, j });

                if (IsPalindrome(ref words[j], ref words[i]))
                    result.Add(new List<int> { j, i });
            }

            return result;
        }

        bool IsPalindrome(ref string s1, ref string s2)
        {
            var length1 = s1.Length;
            var length2 = s2.Length;
            var length = length1 + length2;

            for (var i = 0; i < length / 2; i++)
            {
                var ch1 = i < length1 ? s1[i] : s2[i - length1];
                var ch2 = i < length2 ? s2[length2 - 1 - i] : s1[length1 - 1 + length2 - i];
                if (ch1 != ch2) return false;
            }

            return true;
        }
    }
}