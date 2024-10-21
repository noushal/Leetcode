public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        HashSet<int> seen = new HashSet<int>();
        List<int> result = new List<int>();

        foreach(int num in nums){
            if(!seen.Add(num)){
                result.Add(num);
            }
        }
        return result.ToArray();
    }
}