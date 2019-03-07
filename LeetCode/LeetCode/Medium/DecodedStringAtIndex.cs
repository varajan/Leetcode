using System;
using System.Collections.Generic;
using System.Linq;
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
                lengths.Add(length);
                length *= segments[i].Item2;

                if (K <= length) break;
            }

            var ii = K % lengths.Last() == 0 ? lengths.Last() : K % lengths.Last();
            int subSequence = 0;
            for (; subSequence < lengths.Count; subSequence++)
            {
                if (ii <= lengths[subSequence]) break;
            }

            double index = 0;
            if (subSequence == 0)
            {
                index = ii > 0 ? ii : Math.Min(K, lengths[subSequence]);
            }
            else
            {
                index = ii - lengths[subSequence - 1] * segments[subSequence - 1].Item2;

                if (index <= 0)
                {
                    subSequence--;
                    
                    index = ii % lengths[subSequence];
                    if (index == 0) index = lengths[subSequence];
                }
            }

            return segments[subSequence].Item1.Length > (int) index - 1
                ? segments[subSequence].Item1[(int) index - 1].ToString()
                : DecodeAtIndex(S, (int) index);
        }
//         public static string DecodeAtIndex(string S, int K)
//        {
//            double count;
//            var regex = "([a-z]+)(\\d*)";
//            var parts = Regex.Matches(S, regex).Select(x => x.Value);
//            var segments = parts.Select(part =>
//                new Tuple<string, double>(Regex.Match(part, regex).Groups[1].Value,
//                    double.TryParse(Regex.Match(part, regex).Groups[2].Value, out count) ? count : 1)).ToList();
//
//            double length = 0;
//            var lengths = new List<double>();
//            for (var i = 0; i < segments.Count; i++)
//            {
//                length += segments[i].Item1.Length;
//                lengths.Add(length);
//                length *= segments[i].Item2;
//
//                if (K <= length) break;
//            }
//
//            var ii = K % lengths.Last() == 0 ? lengths.Last() : K % lengths.Last();
//            int subSequence = 0;
//            for (; subSequence < lengths.Count; subSequence++)
//            {
//                if (ii <= lengths[subSequence]) break;
//            }
//
//            double index = 0;
//            if (subSequence == 0)
//            {
//                index = ii > 0 ? ii : Math.Min(K, lengths[subSequence]);
//            }
//            else
//            {
//                index = ii - lengths[subSequence - 1] * segments[subSequence - 1].Item2;
//
//                if (index < 0)
//                {
//                    subSequence--;
//                    
//                    index = ii % lengths[subSequence];
//                    if (index == 0) index = lengths[subSequence];
//                }
//            }
//
//            return segments[subSequence].Item1[(int) index - 1].ToString();
//        }
    }
}