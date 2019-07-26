using System.Collections.Generic;

namespace LeetCode.Hard
{
    public class TextJustification
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            var start = 0;
            var result = new List<string>();

            while (start < words.Length)
            {
                result.Add(ConstructLine());
            }

            return result;

            // ============= functions =============

            string ConstructLine()
            {
                var line = string.Empty;
                var wordsCount = GetWordsCount();
                var spacesCount = GetSpacesCount();
                var isLastLine = IsLastLine();
                var spacesLength = wordsCount > 1 ? spacesCount / (wordsCount - 1) : 0;
                var extraSpaces = wordsCount > 1 ? spacesCount % (wordsCount - 1) : int.MaxValue;
                var spaces = GetSpaces(spacesLength);

                for (var i = 0; i < wordsCount; i++)
                {
                    line += words[i + start];
                    line += isLastLine ? " " : spaces;
                    if (!isLastLine && i < extraSpaces) line += " ";
                }

                line = line.Trim();
                start += wordsCount;

                return line + GetSpaces(maxWidth - line.Length);

                // ============= sub-functions =============
                bool IsLastLine() => start + wordsCount == words.Length;

                string GetSpaces(int length)
                {
                    var x = string.Empty;
                    for (var i = 0; i < length; i++)
                    {
                        x += " ";
                    }

                    return x;
                }

                int GetSpacesCount()
                {
                    int length = 0;

                    for (int i = start; i < start + wordsCount; i++)
                    {
                        length += words[i].Length;
                    }

                    return maxWidth - length;
                }

                int GetWordsCount()
                {
                    int lineWidth = words[start].Length;

                    for (int i = start + 1; i < words.Length; i++)
                    {
                        lineWidth += words[i].Length + 1;

                        if (lineWidth > maxWidth) return i - start;
                    }

                    return words.Length - start;
                }
            }
        }
    }
}