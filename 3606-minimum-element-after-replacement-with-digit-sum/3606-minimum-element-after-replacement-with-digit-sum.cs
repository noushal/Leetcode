public class Solution {
    public int MinElement(int[] nums) {
        int minvalue = int.MaxValue;

        foreach(int num in nums){
            int digitsum = num.ToString().Sum(c => c - '0');
            minvalue = Math.Min(minvalue, digitsum);
        }
        return minvalue;
    }
}