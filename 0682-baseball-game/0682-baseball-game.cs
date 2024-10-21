public class Solution {
    public int CalPoints(string[] operations) {
        List<int> res = new List<int>();

        for (int i = 0; i < operations.Length; i++) {
            string op = operations[i];

            if (int.TryParse(op, out int number)) {
                res.Add(number);
            } else if (op == "C") {
                if (res.Count > 0) {
                    res.RemoveAt(res.Count - 1);
                }
            } else if (op == "D") {
                if (res.Count > 0) {
                    res.Add(res[res.Count - 1] * 2);
                }
            } else if (op == "+") {
                if (res.Count >= 2) {
                    res.Add(res[res.Count - 1] + res[res.Count - 2]);
                } else if (res.Count == 1) {
                    res.Add(res[0]);
                }
            }
        }
        return res.Sum();
    }
}