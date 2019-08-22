public class FindFirstAndLastPositionElementSortedArray {
    public int[] SearchRange(int[] nums, int target) {
        var result = new [] {-1, -1};
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (target < nums[i]) break;
            if (target > nums[i]) continue;
            
             result[1] = i;
            if (result[0] == -1) result[0] = i;
        }
        
        return result;
    }
}
