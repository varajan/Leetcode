using System.Collections.Generic;

namespace LeetCode.Medium
{
    class ReplacePattern
    {
        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            var result = new List<string>();

            foreach (var word in words)
            {
                if (word.Length != pattern.Length) { result.Add("1"); continue; }

                var tempWord = word;
                var tempPatter = pattern;
                for (int i = 0; i < pattern.Length; i++)
                {
                    if (tempPatter[i] < 124 && tempWord[i] > 96)
                    {
                        tempWord = tempWord.Replace(tempWord[i], (char)(tempPatter[i] - 32));
                        tempPatter = tempPatter.Replace(tempPatter[i], '|');
                    }
                }

                if (tempWord == pattern.ToUpper())
                    result.Add(word);
            }

            return result;
        }
    }
}
