public class Solution {
    public int SumOfEncryptedInt(int[] nums) {
        int[] res = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++){
            int num = nums[i].ToString().Length;
            int x = 1;
            for(int j = 1; j < num; j++){
                x = x * 10 + 1;
            }
            res[i] = x;
        }
        
        int sum = 0;

        for(int i = 0; i < nums.Length; i++){
            sum += res[i] * nums[i].ToString()
                    .Select(c => int.Parse(c.ToString()))
                    .Max();
        }
        return sum;
    }
}