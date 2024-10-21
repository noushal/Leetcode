public class Solution {
    public int ReturnToBoundaryCount(int[] nums) {
        int position = 0;
        int boundaryCount = 0;

        foreach(int move in nums){
            position += move;

            if(position == 0){
                boundaryCount++;
            }
        }
        return boundaryCount;
    }
}