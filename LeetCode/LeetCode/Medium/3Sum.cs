using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    public static class _3Sum
    {
        public static List<List<int>> ThreeSum(int[] nums)
        {
            var result = new List<List<int>>();
            var set = new HashSet<string>();
            var jj = false;

            if (nums.Length < 3)
            {
                return result;
            }

            nums = nums.OrderBy(x => x).ToArray();

            for (var i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                jj = false;
                for (var j = nums.Length - 1; j > i; j--)
                {
                    if (jj && nums[j] == nums[j + 1]) continue;
                    jj = true;

                    for (var k = i + 1; k < j; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            var line = $"{nums[i]},{nums[j]},{nums[k]}";

                            if (!set.Contains(line))
                            {
                                result.Add(new List<int> { nums[i], nums[j], nums[k] });
                                set.Add(line);
                            }
                        }
                    }
                }
            }

            return result;
        }
    }
}
