public class Solution {
    public int CountKeyChanges(string s) {
        int changes = 0;
        char lastKey = char.ToLower(s[0]);

        for (int i = 1; i < s.Length; i++) {
            char currentKey = char.ToLower(s[i]);

            if (currentKey != lastKey) {
                changes++;
                lastKey = currentKey;
            }
        }
        
        return changes;
    }
}