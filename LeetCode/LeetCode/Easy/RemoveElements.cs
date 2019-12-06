namespace LeetCode.Easy
{
    public class RemoveElements
    {
        public int RemoveElement(int[] nums, int val)
        {
            int length = nums.Length;

            for(var i = 0; i < length; i++)
            {
                if (nums[i] == val)
                {
                    while(i < length)
                    {
                        if (nums[length - 1] != val) break;

                        length--;
                    }

                   if (length > i) nums[i] = nums[--length];
                }
            }

            return length > 0 ? length : 0;
        }
    }
}