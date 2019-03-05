using System;

namespace LeetCode.Medium
{
    public static class MaxAreaOfIsland
    {
        public static int AreaOfIsland(int[,] grid)
        {
            var height = grid.GetUpperBound(0);
            var width = grid.GetUpperBound(1);
            var result = 0;

            for (int i = 0; i <= width; i++)
            {
                for (int j = 0; j <= height; j++)
                {
                    if (grid[j, i] == 1)
                    {
                        result = Math.Max(result, CalculateArea(ref grid, 1, i, j, height, width));
                    }
                }
            }

            return result;
        }

        private static int CalculateArea(ref int[,] map, int area, int x, int y, int height, int width)
        {
            map[y, x] = 0;

            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    if (Math.Abs(dx) != Math.Abs(dy))
                    {
                        var xx = x + dx;
                        var yy = y + dy;
                        if (0 <= xx && xx <= width && 0 <= yy && yy <= height && map[yy, xx] == 1)
                        {
                            area = CalculateArea(ref map, ++area, xx, yy, height, width);
                        }
                    }
                }
            }

            return area;
        }
   }
}