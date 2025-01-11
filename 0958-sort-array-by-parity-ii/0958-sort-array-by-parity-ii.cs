public class Solution {
    public int[] SortArrayByParityII(int[] nums) {
        int n = nums.Length;
        int evenIndex = 0, oddIndex = 1;

        while(evenIndex < n && oddIndex < n){
            if(nums[evenIndex] % 2 == 0){
                evenIndex += 2;
            }else if(nums[oddIndex] % 2 == 1){
                oddIndex += 2;
            }else{
                int temp = nums[evenIndex];
                nums[evenIndex] = nums[oddIndex];
                nums[oddIndex] = temp;

                evenIndex += 2;
                oddIndex += 2;
            }
        }
        return nums;
    }
}