public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) {
        HashSet<int> set = new HashSet<int>();

        for(int i = 0; i < nums1.Length; i++){
            set.Add(nums1[i]);
        }
        for(int i = 0; i < nums2.Length; i++){
            if(set.Contains(nums2[i])){
                return nums2[i];
            }
        }
        return -1;
    }
}