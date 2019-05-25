//https://leetcode.com/problems/paint-house/

public class Solution {
    public int MinCost(int[,] costs) {
        int n = costs.GetLength(0);
        if(n == 0) return 0;
        int[,] dp = new int[n, 3];
        dp[0, 0] = costs[0, 0];
        dp[0, 1] = costs[0, 1];
        dp[0, 2] = costs[0, 2];
        for(int i = 1; i < n; i++){
            dp[i, 0] = Math.Min(dp[i-1, 1] + costs[i, 0], dp[i-1, 2] + costs[i, 0]);
            dp[i, 1] = Math.Min(dp[i-1, 0] + costs[i, 1], dp[i-1, 2] + costs[i, 1]);
            dp[i, 2] = Math.Min(dp[i-1, 0] + costs[i, 2], dp[i-1, 1] + costs[i, 2]);
        }
        int min = Math.Min(dp[n-1, 0], dp[n-1, 1]);
        min = Math.Min(min, dp[n-1, 2]);
        return min;
    }
}
