using System;

namespace LeetCode.Medium
{
    public static class ContainerWithMostWater
    {
        public static int MaxArea(int[] height)
        {
            var result = 0;

            if (height.Length < 2) return result;

            for (var i = 0; i < height.Length-1; i++)
            {
                if (height[i]==0) continue;

                for (var j = height.Length-1; j > i; j--)
                {
                    if (height[j] == 0) continue;

                    var s = (j-i) * Math.Min(height[i], height[j]);
                    result = Math.Max(result, s);
                }
            }

            return result;
        }
    }
}
