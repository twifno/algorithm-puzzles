//https://leetcode.com/problems/minimum-path-sum/

//DP

public class Solution {
    public int MinPathSum(int[,] grid) {
        int l0 = grid.GetLength(0);
        int l1 = grid.GetLength(1);
        int[,] dp = new int[l0,l1];
        dp[0,0] = grid[0,0];
        for(int i = 0; i < l0; i++){
            for(int j = 0; j < l1; j++){
                if(i == 0 && j == 0) continue;
                if(i == 0) dp[i,j] = dp[i,j-1] + grid[i, j];
                else if(j == 0) dp[i,j] = dp[i-1, j] + grid[i, j];
                else dp[i,j] = Math.Min(dp[i, j-1], dp[i-1,j]) + grid[i, j];
            }
        }
        return dp[l0-1,l1-1];
    }
}
