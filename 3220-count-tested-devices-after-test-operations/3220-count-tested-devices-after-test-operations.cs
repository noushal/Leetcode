public class Solution {
    public int CountTestedDevices(int[] batteryPercentages) {
        int testedDevices = 0;
        int n = batteryPercentages.Length;

        for (int i = 0; i < n; i++) {
            if (batteryPercentages[i] > 0) {
                testedDevices++;
                for (int j = i + 1; j < n; j++) {
                    batteryPercentages[j] = Math.Max(0, batteryPercentages[j] - 1);
                }
            }
        }

        return testedDevices;
    }
}