public class Solution {
    public int FillCups(int[] amount) {
        Array.Sort(amount);
        int total = amount[0] + amount[1] + amount[2];
        int max = amount[2];
        
        return Math.Max(max, (total + 1) / 2);
    }
}