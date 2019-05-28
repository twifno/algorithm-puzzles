//https://leetcode.com/problems/knight-dialer/

//DP

public class Solution {
    public int KnightDialer(int N) {
        int[,] dp = new int[N, 10];
        int p = 1000000007;
        for(int i = 0; i < 10; i++) dp[0, i] = 1;
        for(int i = 1; i < N; i++){
            dp[i, 0] = (dp[i-1, 4] + dp[i-1, 6]) % p;
            dp[i, 1] = (dp[i-1, 6] + dp[i-1, 8]) % p;
            dp[i, 2] = (dp[i-1, 7] + dp[i-1, 9]) % p;
            dp[i, 3] = (dp[i-1, 4] + dp[i-1, 8]) % p;
            dp[i, 4] = ((dp[i-1, 3] + dp[i-1, 9]) % p + dp[i-1, 0]) % p;
            dp[i, 5] = 0;
            dp[i, 6] = ((dp[i-1, 1] + dp[i-1, 7]) % p + dp[i-1, 0]) % p;
            dp[i, 7] = (dp[i-1, 6] + dp[i-1, 2]) % p;
            dp[i, 8] = (dp[i-1, 1] + dp[i-1, 3]) % p;
            dp[i, 9] = (dp[i-1, 2] + dp[i-1, 4]) % p;
        }
        int sum = 0;
        for(int i = 0; i < 10; i++) sum = (sum + dp[N-1, i]) % p;
        return sum;
    }
}
