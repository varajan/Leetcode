using System;
using System.Collections.Generic;

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
                        result = Math.Max(result, CalculateArea(ref grid, 1, i, j));
                    }
                }
            }

            return result;
        }

        private static int CalculateArea(ref int[,] map, int area, int x, int y)
        {
            var roots = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(-1, 0),
                new Tuple<int, int>(0, -1),
                new Tuple<int, int>(1, 0),
                new Tuple<int, int>(0, 1)
            };

            map[y, x] = 0;

            foreach (var root in roots)
            {
                var has = HasSomething(ref map, x, y, root.Item1, root.Item2);

                if (HasSomething(ref map, x, y, root.Item1, root.Item2))
                {
                    area = CalculateArea(ref map, ++area, x + root.Item1, y + root.Item2);
                }
            }

            return area;
        }

        private static bool HasSomething(ref int[,] map, int x, int y, int dx, int dy)
        {
            var height = map.GetUpperBound(0);
            var width = map.GetUpperBound(1);
            var xx = x + dx;
            var yy = y + dy;

            return 0 <= xx && xx <= width && 0 <= yy && yy <= height && map[yy, xx] == 1;
        }
    }
}