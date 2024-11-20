public class Solution {
    public int MinElement(int[] nums) {
        // for(int i = 0; i < nums.Length; i++){
        //     if(nums[i] <= 10 && nums.Length != 1 || nums.Length == 1 && nums[i] > 10){
        //         return 1;
        //     }else if(nums[i] <= 9){
        //         return nums[i];
        //     }else if(nums[i] <= 100){
        //         return 10;
        //     }
        // }
        // return -1;

        // string value = nums.Min().ToString();
        // value.Split("");
        // return value;

        int minElement = int.MaxValue;

        foreach (int num in nums) {
            int digitSum = num.ToString().Sum(c => c - '0');
            minElement = Math.Min(minElement, digitSum);
        }

        return minElement;
    }
}