public class Solution {
    public int MissingNumber(int[] nums) {
        Array.Sort(nums);
        int i;
        for(i = 0; i < nums.Length; i++){
            if(i != nums[i]){
                return i;
            }
        }
        return i;
    }
}