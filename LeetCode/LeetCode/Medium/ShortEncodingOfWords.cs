using System;
using System.Text;

namespace LeetCode.Medium
{
    public class ShortEncodingOfWords
    {
        public int MinimumLengthEncoding(params string[] words)
        {
            var previous = "";
            var result = 0;

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = Reverse(words[i]);
            }

            Array.Sort(words);

            for (int i = words.Length-1; i >= 0; i--)
            {
                var word = words[i];
                if (previous.StartsWith(word)) continue;

                result += word.Length + 1;
                previous = word;
            }

            return result;

            string Reverse(string word)
            {
                var reverse = new StringBuilder();

                for (int i = word.Length - 1; i >= 0; i--) reverse.Append(word[i]);

                return reverse.ToString();
            }
        }
    }
}