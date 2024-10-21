public class Solution {
    public int FindGCD(int[] nums) {
        int minNum = nums.Min();
        int maxNum = nums.Max();
        return GCD(minNum, maxNum);
    }
    private int GCD(int a, int b) {
        return b == 0 ? a : GCD(b, a % b);
    }
}