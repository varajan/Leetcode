using System.Collections.Generic;

namespace LeetCode.Easy
{
    public class Nth_TribonacciNumber
    {
        public int Tribonacci(int n)
        {
            var tribonacci = new List<int> { 0, 1, 1 };

            for (int i = 3; i <= n; i++)
            {
                tribonacci.Add(tribonacci[i - 1] + tribonacci[i - 2] + tribonacci[i - 3]);
            }

            return tribonacci[n];
        }
    }
}