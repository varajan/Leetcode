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

			if (nums.Count() < 3)
			{
				return result;
			}

			nums = nums.OrderBy(x => x).ToArray();

			for (var i = 0; i < nums.Count() - 2; i++)
			{
				for (var j = i+1; j < nums.Count() - 1; j++)
				{
					for (var k = j+1; k < nums.Count(); k++)
					{
						if (nums[i] + nums[j] + nums[k] == 0)
						{
							var row = new List<int> {nums[i], nums[j], nums[k]}.OrderBy(x => x).ToList();
							var line = $"{nums[i]},{nums[j]},{nums[k]}";

							if (!set.Contains(line))
							{
								result.Add(row);
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
