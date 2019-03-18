using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LeetCode.Medium
{
    public static class DecodedStringAtIndex
    {
        public static string DecodeAtIndex(string S, int K)
        {
            double count;
            var regex = "([a-z]+)(\\d*)";
            var parts = Regex.Matches(S, regex).Select(x => x.Value);
            var segments = parts.Select(part =>
                new Tuple<string, double>(Regex.Match(part, regex).Groups[1].Value,
                    double.TryParse(Regex.Match(part, regex).Groups[2].Value, out count) ? count : 1)).ToList();

            double length = 0;
            var lengths = new List<double>();
            for (var i = 0; i < segments.Count; i++)
            {
                length += segments[i].Item1.Length;
                length *= segments[i].Item2;
                lengths.Add(length);
            }

            if (lengths.Last() == K) return segments.Last().Item1.Last().ToString();
            var ii = 0;
            for (; ii < lengths.Count; ii++)
            {
                if (K < lengths[ii]) break;
            }

            for (var i = ii; i > 0; i--)
            {
                var segmentLength = (int)(lengths[i] / segments[i].Item2);
                var subSegmentLength = (int)lengths[i - 1];

                K = K % segmentLength == 0 ? segmentLength : K % segmentLength;

                if (K > subSegmentLength)
                {
                    K %= subSegmentLength;
                    return segments[i].Item1[K - 1].ToString();
                }
                K %= subSegmentLength;
            }

            var segment = segments[0].Item1;
            K = K % segment.Length == 0 ? segment.Length : K % segment.Length;
            return segment[K - 1].ToString();
        }
    }
}