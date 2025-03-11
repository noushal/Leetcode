public class Solution {
    public int MaximumDifference(int[] nums) {
        int minValue = nums[0];
        int maxDifference = -1;

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] > minValue) {
                maxDifference = Math.Max(maxDifference, nums[i] - minValue);
            } else {
                minValue = nums[i];
            }
        }

        return maxDifference;
    }
}