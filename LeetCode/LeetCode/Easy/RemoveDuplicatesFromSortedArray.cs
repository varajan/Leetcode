public class RemoveDuplicatesFromSortedArray {
    public int RemoveDuplicates(int[] nums) {
        int result = 0;
        int index = 0;
                
        while (index < nums.Length)
        {
            while (index + 1 < nums.Length && nums[index] == nums[index+1]) index++;
            nums[result++] = nums[index++];
        }
        
        return result;
    }
}
