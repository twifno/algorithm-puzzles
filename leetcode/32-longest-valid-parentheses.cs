//https://leetcode.com/problems/longest-valid-parentheses/

//Dynamic programming

public class Solution {
    public int LongestValidParentheses(string s) {
        int[] dp = new int[s.Length];
        int max = 0;
        for(int i = 0; i < s.Length; i++){
            if(s[i] == ')') {
                if(i > 0 && i-1-dp[i-1] >= 0 && s[i-1-dp[i-1]] == '(') {
                    dp[i] = dp[i-1] + 2;
                    if(i - dp[i] > 0) dp[i] += dp[i - dp[i]];
                    max = Math.Max(dp[i], max);
                }
            }
        }
        return max;
    }
}
