public class Solution {
    public int Rob(int[] nums) {
        if (nums == null || nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];

        int prev2 = 0;
        int prev1 = 0;

        foreach (int num in nums) {
            int current = Math.Max(prev1, prev2 + num);
            prev2 = prev1;
            prev1 = current;
        }

        return prev1;
    }
}