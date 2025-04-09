public class Solution {
    public double TrimMean(int[] arr) {
        Array.Sort(arr);
        
        int n = arr.Length;
        int remove = n / 20;
        
        int sum = 0;
        for (int i = remove; i < n - remove; i++) {
            sum += arr[i];
        }

        return (double)sum / (n - 2 * remove);
    }
}