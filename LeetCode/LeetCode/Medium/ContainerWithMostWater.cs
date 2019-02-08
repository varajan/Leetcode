using System;

namespace LeetCode.Medium
{
    public static class ContainerWithMostWater
    {
        public static int MaxArea(int[] height)
        {
            var result = 0;
            for (var i = 0; i < height.Length-1; i++)
            {
                for (var j = height.Length-1; j > i; j--)
                {
                    var s = (j-i) * Math.Min(height[i], height[j]);
                    result = Math.Max(result, s);
                }
            }

            return result;
        }
    }
}
