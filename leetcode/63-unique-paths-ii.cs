//https://leetcode.com/problems/unique-paths-ii/

//Typical DP.

public class Solution {
    public int UniquePathsWithObstacles(int[,] obstacleGrid) {
        int l0 = obstacleGrid.GetLength(0);
        int l1 = obstacleGrid.GetLength(1);
        int[,] dp = new int[l0,l1];
        int[,] ob = obstacleGrid;
        if(ob[0,0] == 1 || ob[l0-1,l1-1] == 1) return 0;
        dp[0,0] = 1;
        for(int i = 0; i < l0; i++){
            for(int j = 0; j < l1; j++){
                if(ob[i,j] == 1) continue;
                if(i > 0) dp[i,j] += dp[i-1,j];
                if(j > 0) dp[i,j] += dp[i,j-1];
            }
        }
        return dp[l0-1, l1-1];
    }
}
