public class Solution {
    public bool IsAnagram(string s, string t) {
        return String.Join("", s.OrderBy(c => c)) == String.Join("", t.OrderBy(c => c));
    }
}