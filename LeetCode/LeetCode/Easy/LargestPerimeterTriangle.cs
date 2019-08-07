using System;

namespace LeetCode.Easy
{
    class LargestPerimeterTriangle
    {
        public int LargestPerimeter(int[] A)
        {
            Array.Sort(A);

            int a, b, c;

            for (int i = A.Length - 1; i > 1; i--)
            {
                a = A[i];
                b = A[i - 1];
                c = A[i - 2];

                if (b + c > a) return a + b + c;
            }

            return 0;
        }
    }
}