using System;
using System.Linq;

namespace LeetCode.Easy
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            if (x == int.MinValue) return 0;
            var positive = x > 0;
            var asString = Math.Abs(x).ToString().Aggregate("", (current, c) => c + current);

            return int.TryParse(asString, out var result) ? (positive ? result : -result) : 0;
        }
    }
}