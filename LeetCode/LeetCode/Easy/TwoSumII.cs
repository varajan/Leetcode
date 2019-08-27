public class TwoSumII {
    public int[] TwoSum(int[] nums, int target) {
        int i = 0;
        int j = nums.Length - 1;
        
        while (true){
            int sum = nums[i] + nums[j];
            
            if (sum < target) { i++; continue; }
            if (sum > target) { j--; continue; }
            
            return new [] {i+1, j+1};
        }
    }
}
