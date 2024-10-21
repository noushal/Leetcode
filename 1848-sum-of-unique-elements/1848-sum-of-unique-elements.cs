public class Solution {
    public int SumOfUnique(int[] nums) {
        return nums.GroupBy(n => n)
                    .Where(g => g.Count() == 1)
                    .Sum(g => g.Key);
    }
}