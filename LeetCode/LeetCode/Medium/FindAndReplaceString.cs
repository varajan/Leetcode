using System;
using System.Linq;

namespace LeetCode.Medium
{
    public class FindAndReplaceString
    {
        public string FindReplaceString(string S, int[] indexes, string[] sources, string[] targets)
        {
            var inputs = indexes
                .Select((t, i) => new Tuple<int, string, string>(t, sources[i], targets[i])).OrderBy(x => x.Item1)
                .ToList();

            var offset = 0;

            foreach (var input in inputs)
            {
                if (GetSubString(S, input.Item1 + offset, input.Item2.Length) == input.Item2)
                {
                    S = S.Remove(input.Item1 + offset, input.Item2.Length);
                    S = S.Insert(input.Item1 + offset, input.Item3);
                    offset += input.Item3.Length - input.Item2.Length;
                }
            }

            return S;
        }

        private string GetSubString(string line, int index, int length)
        {
            return line.Length < index + length ? string.Empty : line.Substring(index, length);
        }
    }
}