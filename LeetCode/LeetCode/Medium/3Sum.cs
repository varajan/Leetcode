using System;
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

            Array.Sort(nums);

            for (var i = 0; i < nums.Length-2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                for (var j = nums.Length - 1; j > i; j--)
                {
                    if (j < nums.Length - 1 && nums[j] == nums[j + 1]) continue;

                    var sum2 = nums[i] + nums[j];

                    for (var k = i + 1; k < j; k++)
                    {
                        if (sum2 == -nums[k])
                        {
                            var line = $"{nums[i]},{nums[j]},{nums[k]}";

                            if (!set.Contains(line))
                            {
                                result.Add(new List<int> { nums[i], nums[j], nums[k] });
                                set.Add(line);
                                break;
                            }
                        }
                    }
                }
            }

            return result;
        }
    }
}
