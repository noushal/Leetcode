public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int[] sortedNums = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++){
            int count = 0;
            for(int j = 0; j < nums.Length; j++){
                if(j != i && nums[j] < nums[i]){
                    count++;
                }
            }
            sortedNums[i] = count;
        }
        return sortedNums;
    }
}