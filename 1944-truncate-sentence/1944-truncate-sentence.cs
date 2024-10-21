public class Solution {
    public string TruncateSentence(string s, int k) {
        string[] words = s.Split(' ');
        
        string truncateSentence = String.Join(' ', words.Take(k));

        return truncateSentence;
    }
}