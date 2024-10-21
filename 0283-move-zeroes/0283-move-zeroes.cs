public class Solution {
    public void MoveZeroes(int[] nums) {
        for(int i = 0; i < nums.Length; i++){
            for(int j = i+1; j < nums.Length; j++){
                if(nums[i] == 0){
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
    }
}