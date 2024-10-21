public class Solution {
    public bool CheckIfPangram(string sentence) {
        HashSet<char> uniqueChars = new HashSet<char>(sentence.ToCharArray());
        
        foreach(char c in sentence){
            if(char.IsLetter(c)){
                uniqueChars.Add(c);
            }
        }
        return uniqueChars.Count == 26;
    }
}