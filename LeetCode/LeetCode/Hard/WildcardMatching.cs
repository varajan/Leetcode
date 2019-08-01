using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LeetCode.Hard
{
    public class WildcardMatching
    {
        public bool IsMatch(string s, string p)
        {
            var chars = GetChars();
            p = p.Replace("?", $"[{chars}]");
            p = Regex.Replace(p, @"\*+", $"[{chars}]*");

            return Regex.IsMatch(s, $"^{p}$");

            string GetChars()
            {
                var set = new HashSet<char>();
                var result = "";

                foreach (var c in s)
                {
                    set.Add(c);
                }

                foreach (var c in set)
                {
                    result += $"{c}";
                }

                return result;
            }
        }
    }
}