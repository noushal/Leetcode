public class Solution {
    public int MinimumSum(int num) {
        int[] digits = num.ToString().Select(d => d - '0').ToArray();
        Array.Sort(digits);

        int new1 = digits[0] * 10 + digits[2];
        int new2 = digits[1] * 10 + digits[3];

        return new1 + new2;
    }
}