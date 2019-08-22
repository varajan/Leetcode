public class RemoveDuplicatesFromSortedArrayII {
    public int RemoveDuplicates(int[] nums) {
        int result = 0;
        int index = 0;
                
        while (index < nums.Length)
        {
            int count = 0;
            while (index + 1 < nums.Length && nums[index] == nums[index+1])
            {
                index++;
                count++;
            }
            
            if (count > 0) nums[result++] = nums[index];
            
            nums[result++] = nums[index++];
        }
        
        return result;
    }
}
