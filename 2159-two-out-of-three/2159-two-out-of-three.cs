public class Solution {
    public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3) {
        int[] result = new int[100];
        int len = 0;
        for(int i = 1; i <= 100; i++){
            if(nums1.Contains(i) && nums2.Contains(i) && nums3.Contains(i) && !result.Contains(i)){
                result[len++] = i;
            }
        }
        for(int i = 1; i <= 100; i++){
            if(!result.Contains(i)){
            if(nums1.Contains(i) && nums3.Contains(i)){
                result[len++] = i;
            }else if(nums1.Contains(i) && nums2.Contains(i)){
                result[len++] = i;
            }else if(nums2.Contains(i) && nums3.Contains(i)){
                result[len++] = i;
            }
            }
        }
        return result.Where(x => x != 0).ToArray();
    }
}