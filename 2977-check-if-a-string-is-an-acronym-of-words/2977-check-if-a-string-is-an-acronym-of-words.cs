public class Solution {
    public bool IsAcronym(IList<string> words, string s) {
        return (string.Join("", words.Select(words => words[0])) == s)? true : false;
    }
}