public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        
        Dictionary<int,int> frequency = new Dictionary<int, int>();

        foreach(int num in arr)
            frequency[num] = frequency.ContainsKey(num) ? frequency[num]+1 : 1;

        HashSet<int> storage = new HashSet<int>();
        foreach(var key in frequency)
            if(storage.Contains(key.Value)) return false;
            else storage.Add(key.Value);

        return true;
    }
}