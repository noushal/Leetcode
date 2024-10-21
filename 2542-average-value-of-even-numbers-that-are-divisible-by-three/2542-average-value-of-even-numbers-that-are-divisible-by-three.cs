public class Solution {
    public int AverageValue(int[] nums) {
        int sum = 0;
        int count = 0;

        foreach(int num in nums){
            if(num % 2 == 0 && num % 3 == 0){
                sum += num;
                count++;
            }
        }

        if(count == 0){
            return 0;
        }

        return sum / count;
    }
}