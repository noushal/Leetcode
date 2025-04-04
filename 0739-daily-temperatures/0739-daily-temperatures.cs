public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        int[] answer = new int[n];
        Stack<int> stack = new Stack<int>();
        
        for (int i = 0; i < n; i++) {
            while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()]) {
                int index = stack.Pop();
                answer[index] = i - index;
            }
            stack.Push(i);
        }
        
        return answer;
    }
}