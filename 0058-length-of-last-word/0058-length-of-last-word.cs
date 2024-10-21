public class Solution {
    public int LengthOfLastWord(string s) {
        s = s.Trim();
        string[] word = s.Split(' ');
        return word[word.Length - 1].Length;
    }
}