public class Solution {
    public int MaxProductDifference(int[] nums) {
        Array.Sort(nums);
        int n = nums.Length;
        
        int max = nums[n - 1] * nums[n - 2];
        int min = nums[0] * nums[1];
        
        return max - min;
    }
}