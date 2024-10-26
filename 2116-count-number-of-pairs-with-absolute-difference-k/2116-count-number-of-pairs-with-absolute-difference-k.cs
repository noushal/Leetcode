public class Solution {
    public int CountKDifference(int[] nums, int k) {
        int count = 0;
        int n = nums.Length;

        for (int i = 0; i < n; i++) {
            for (int j = i + 1; j < n; j++) {
                if (Math.Abs(nums[i] - nums[j]) == k) {
                    count++;
                }
            }
        }

        return count;
    }
}