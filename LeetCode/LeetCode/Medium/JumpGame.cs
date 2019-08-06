namespace LeetCode.Medium
{
    public class JumpGame
    {
        public bool CanJump(int[] nums)
        {
            var visited = new bool[nums.Length];

            return TryJump(0);

            bool TryJump(int i)
            {
                SetVisited(i);

                if (i + 1 >= nums.Length) return true;

                for (int x = nums[i]; x > 0; x--)
                {
                    if (IsVisited(i+x)) continue;

                    var jump = TryJump(i + x);
                    if (jump) return true;
                }

                return false;
            }


            bool IsVisited(int i) => i > visited.Length || visited[i];
            void SetVisited(int i)
            {
                if (i < visited.Length) visited[i] = true;
            }
        }
    }
}