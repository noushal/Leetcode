public class Solution {
    public int ScoreOfString(string s) {
        int res = 0, n = s.Length - 1;
        for (int i = 0; i < n; i++) {
            int diff = s[i] - s[i + 1];
            res += diff > 0 ? diff : -diff;
        }
        return res;
    }
}