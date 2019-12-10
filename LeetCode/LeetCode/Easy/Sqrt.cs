using System;
using System.Linq;

namespace LeetCode.Easy
{
    class Sqrt
    {
        public int MySqrt(int x) => int.Parse(Math.Sqrt(x).ToString().Split('.').First());
    }
}