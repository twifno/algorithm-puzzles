//https://leetcode.com/problems/longest-palindromic-subsequence/

public class Solution {    
    public int LongestPalindromeSubseq(string s) {
        int len = s.Length;
        int[,] dp = new int[len, len];
        for(int i = 0; i < len; i++) {
            dp[i, i] = 1;
        }
        for(int i = 0; i < len-1; i++){
            if(s[i] == s[i+1]) dp[i, i+1] = 2;
            else dp[i, i+1] = 1;
        }
        for(int i = 2; i < len; i++){
            for(int j = 0; j < len-i; j++){
                if(s[j] == s[j+i]) dp[j, j+i] = 2 + dp[j+1, j+i-1];
                else dp[j, j+i] = Math.Max(dp[j, j+i-1], dp[j+1, j+i]);
            }
        }
        return dp[0, len-1];
    }
}
