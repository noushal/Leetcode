public class Solution {
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target) {
        int result = 0;
        for(int i = 0; i < hours.Length; i++){
            if(hours[i] >= target){
                result++;
            }
        }
        return result;
    }
}