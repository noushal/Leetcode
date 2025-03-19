public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        List<int> result = new List<int>();

    for (int i = 0; i < nums.Length; i++) {
        int index = Math.Abs(nums[i]) - 1;

        if (nums[index] < 0) {
            result.Add(index + 1);
        } else {
            nums[index] = -nums[index];
        }
    }

    return result;
    }
}