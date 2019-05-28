//https://leetcode.com/problems/decode-ways-ii/

//Pay attention to 0!

public class Solution {
    public int NumDecodings(string s) {
        int len = s.Length;
        int p = 1000000007;
        long[] dp = new long[s.Length];
        if(len == 0) return 1;
        if(s[0] == '*') dp[0] = 9;
        else if(s[0] == '0') return 0;
        else dp[0] = 1;
        if(len == 1) return (int)dp[0];
        for(int i = 1; i < s.Length; i++) {
            if(s[i] == '*') {
                dp[i] += 9 * DP(i-1, dp) % p;
                if(s[i-1] == '1') { dp[i] += 9 * DP(i-2, dp); dp[i] %= p; }
                else if (s[i-1] == '2') { dp[i] += 6 * DP(i-2, dp); dp[i] %= p; }
                else if (s[i-1] == '*') { dp[i] += 15 * DP(i-2, dp); dp[i] %= p; }
            } else if(s[i] == '0') {
                if(s[i-1] == '*') { dp[i] += 2 * DP(i-2, dp); dp[i] %= p; }
                else if(s[i-1] <= '2' && s[i-1] >= '1') { dp[i] += DP(i-2, dp); dp[i] %= p; }
                else return 0;
            } else {
                dp[i] += dp[i-1];
                if(s[i-1] == '1') { dp[i] += DP(i-2, dp); dp[i] %= p; }
                else if (s[i-1] == '2' && s[i] <= '6') { dp[i] += DP(i-2, dp); dp[i] %= p; }
                else if (s[i-1] == '*' && s[i] <= '6') { dp[i] += 2 * DP(i-2, dp); dp[i] %= p; }
                else if (s[i-1] == '*') { dp[i] += DP(i-2, dp); dp[i] %= p; }
            }
        }
        return (int)dp[s.Length-1];
    }
    
    private long DP(int pos, long[] dp){
        if(pos < 0) return 1;
        return dp[pos];
    }
}
