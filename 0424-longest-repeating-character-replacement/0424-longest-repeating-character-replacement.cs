public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] count = new int[26];
        int maxFreq = 0, left = 0, maxLen = 0;
        
        for (int right = 0; right < s.Length; right++) {
            count[s[right] - 'A']++;
            maxFreq = Math.Max(maxFreq, count[s[right] - 'A']);
            
            if ((right - left + 1) - maxFreq > k) {
                count[s[left] - 'A']--;
                left++;
            }
            
            maxLen = Math.Max(maxLen, right - left + 1);
        }
        
        return maxLen;
    }
}