public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        int count = 1;
        IList<int> missingNumbers = new List<int>();
        
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++) {
            while (count < nums[i]) {
                missingNumbers.Add(count);
                count++;
            }

            if (nums[i] == count) {
                count++;
            }
        }

        while (count <= nums.Length) {
            missingNumbers.Add(count);
            count++;
        }

        return missingNumbers;
    }
}