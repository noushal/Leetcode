// public class Solution {
//     public int SingleNumber(int[] nums) {
        
//     }
// }

public class Solution {
    public int SingleNumber(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        
        foreach (int num in nums) {
            if (set.Contains(num)) {
                set.Remove(num);
            } else {
                set.Add(num);
            }
        }

        foreach (int num in set) {
            return num;
        }
        
        return -1;
    }
}