using System;

namespace LeetCode.Hard
{
    public class JumpGameII
    {
        public int Jump(int[] nums)
        {
            var size = nums.Length;
            var visited = new int[size];
            int result = int.MaxValue;
            Jump(0);

            return result;

            void Jump(int i, int step = 0)
            {
                if (size <= i + 1)
                {
                    result = Math.Min(result, step);
                    return;
                }

                SetVisited(i, step++);

                for (int x = nums[i]; x > 0; x--)
                {
                    if (nums[i] > 1000 && x < nums[i]/2) break;
                    if (ValidToVisit(i + x, step)) Jump(i + x, step);
                }
            }

            bool ValidToVisit(int i, int steps)
            {
                return i >= size || visited[i] == 0 || visited[i] >= steps;
            }

            void SetVisited(int i, int steps)
            {
                visited[i] = steps;
            }
        }
    }
}