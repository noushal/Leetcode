public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        int n = names.Length;
        var people = new List<(string name, int height)>();

        for (int i = 0; i < n; i++) {
            people.Add((names[i], heights[i]));
        }

        people.Sort((a, b) => b.height.CompareTo(a.height));

        string[] sortedNames = new string[n];
        for (int i = 0; i < n; i++) {
            sortedNames[i] = people[i].name;
        }

        return sortedNames;
    }
}