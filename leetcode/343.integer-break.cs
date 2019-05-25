//https://leetcode.com/problems/integer-break/

//There is a much better solution
//The integer can break to at most 2 2s and all 3s, 

public class Solution {
    public int IntegerBreak(int n) {
        if(n == 2) return 1;
        if(n == 3) return 2;
        int[] dp = new int[n+1];
        dp[1] = 1;
        for(int i = 2; i <= n; i++){
            int max = i;
            for(int j = 1; j < i; j++){
                max = Math.Max(dp[j] * (i-j), max);
            }
            dp[i] = max;
        }
        return dp[n];
    }
}
