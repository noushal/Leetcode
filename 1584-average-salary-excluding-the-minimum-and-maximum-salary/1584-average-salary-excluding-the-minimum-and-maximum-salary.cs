public class Solution {
    public double Average(int[] salary) {
        double sum = 0;

        for(int i = 0; i < salary.Length; i++){
            sum += salary[i];
        }
        sum -= salary.Max();
        sum -= salary.Min();
        
        return sum / (salary.Length - 2);
    }
}