using System;

namespace LeetCode.Medium
{
    public class Pow
    {
        public double MyPow(double x, int n)
        {
            if (x == 0 || x == 1) return x;
            if (x == -1) n = n % 2;

            double result = 1;
            bool positive = n > 0;

            for (int i = positive ? 0 : n; i < (positive ? n : 0) && result != 0; i++)
                if (positive)
                    result *= x;
                else
                    result /= x;

            return result;
        }
    }
}