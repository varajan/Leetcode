using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy
{
    public static class MostCommonWord
    {
        public static string GetMostCommonWord(string paragraph, string[] banned)
        {
            var words = new Dictionary<string, int>();
            var max = 0;
            var result = "";

            foreach (var word in paragraph.Split(' '))
            {
                var current = word.TrimEnd(',', '.', '!', '?', ';', '\'').ToLower();
                if (word.Length == 0) continue;

                words.TryGetValue(current, out var count);
                words[current] = ++count;

                if (!banned.Contains(current) && count > max)
                {
                    max = count;
                    result = current;
                }
            }

            return result;
        }
    }
}