using System;
using System.Linq;
using System.Text;

namespace LeetCode.Medium
{
    class ReverseWordsInString
    {
        public string ReverseWords(string s)
        {
            var words = s.Split(' ').Where(x => x.Trim().Length > 0).Reverse();

            var result = new StringBuilder();
            foreach (var word in words)
            {
                result.Append(word);
                result.Append(" ");
            }

            return result.ToString().Trim();
        }
    }
}
