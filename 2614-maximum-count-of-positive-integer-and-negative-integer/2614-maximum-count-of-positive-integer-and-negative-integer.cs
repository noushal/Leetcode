public class Solution {
    public int MaximumCount(int[] nums) {
        int pos = 0,neg = 0;
        for(int i =0; i < nums.Length; i++){
            if(nums[i] != 0){
                if(nums[i] < 0){
                    neg++;
                }else if(nums[i] > 0){
                    pos++;
                }
            }
        }
        return Math.Max(pos, neg);
    }
}