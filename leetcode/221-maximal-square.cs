//https://leetcode.com/problems/maximal-square/

public class Solution {
    public int MaximalSquare(char[,] matrix) {
        int l0 = matrix.GetLength(0);
        int l1 = matrix.GetLength(1);
        int[,] up = new int[l0, l1];
        int[,] left = new int[l0, l1];
        int[,] dp = new int[l0, l1];
        int max = Int32.MinValue;
        for(int i = 0; i < l0; i++){
            for(int j = 0; j < l1; j++){
                if(matrix[i, j] == '1') {
                    up[i, j] = (i<=0)? 1:(up[i-1,j]+1);
                    left[i, j] = (j<=0)? 1:(left[i,j-1]+1);
                    dp[i,j] = (i<=0 || j<=0)? 1:(Math.Min(left[i, j], Math.Min(up[i, j], dp[i-1, j-1]+1)));
                    //System.Console.WriteLine(dp[i, j]);
                    max = Math.Max(max, dp[i, j]);
                }
            }
        }
        return max*max;
    }
}

//2D memory space can be limited to 1D