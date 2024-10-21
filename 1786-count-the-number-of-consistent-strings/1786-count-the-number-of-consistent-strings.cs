public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        
            var allowSet = new HashSet<char>(allowed.ToCharArray());

            int count = words.Count(word => word.All(letter => allowSet.Contains(letter)));

            return count;

        }
}