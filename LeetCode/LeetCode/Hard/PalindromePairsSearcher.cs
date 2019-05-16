using System.Collections.Generic;
using System.Linq;

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

//                if (IsPalindrome($"{words[i]}{words[j]}"))
                if (IsPalindrome(words[i] + words[j]))
                    result.Add(new List<int> { i, j });
//                if (IsPalindrome($"{words[j]}{words[i]}"))
                if (IsPalindrome(words[j] + words[i]))
                    result.Add(new List<int> { j, i });
            }

            return result;
        }

        bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;

            var length = s.Length;

            for (var i = 0; i < length / 2; i++)
            {
                if (s[i] != s[length - i - 1]) return false;
            }

            return true;
        }
    }
}