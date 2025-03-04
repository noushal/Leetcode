public class Solution {
    public int[] RowAndMaximumOnes(int[][] mat) {
        int maxOnes = 0, rowIndex = 0;

        for (int i = 0; i < mat.Length; i++) {
            int onesCount = 0;
            for (int j = 0; j < mat[i].Length; j++) {
                if (mat[i][j] == 1) {
                    onesCount++;
                }
            }
            if (onesCount > maxOnes) {
                maxOnes = onesCount;
                rowIndex = i;
            }
        }

        return new int[] { rowIndex, maxOnes };
    }
}