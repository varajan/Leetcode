using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    public class SingleNumber3
    {
        public int[] SingleNumber(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                dictionary[num] = dictionary.ContainsKey(num) ? dictionary[num] + 1 : 1;
            }

            return dictionary.Where(x => x.Value == 1).Select(x => x.Key).ToArray();
        }
    }
}