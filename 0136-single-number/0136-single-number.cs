public class Solution {
    public int SingleNumber(int[] nums) {
        int single = 0;
        foreach(int num in nums){
            single ^= num;
        }
        return single;

    }
}