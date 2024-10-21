public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int[] DistinctElements = nums.Distinct().ToArray();
        for(int i =0;i <DistinctElements.Length; i++){
            nums[i] = DistinctElements[i];
        }
        return DistinctElements.Length;
    }
}