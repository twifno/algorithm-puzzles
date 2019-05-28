//https://leetcode.com/problems/domino-and-tromino-tiling/

public class Solution {
    
    public int NumTilings(int N) {
        if(N <= 1) return 1;
        if(N == 2) return 2;
        int[] dp = new int[N+1];
        dp[0] = 1;
        dp[1] = 1;
        dp[2] = 2;
        for(int i = 3; i <= N; i++){
            dp[i] = (2*dp[i-1] % 1000000007 + dp[i-3]) % 1000000007;
        }
        return dp[N];
    }
}
