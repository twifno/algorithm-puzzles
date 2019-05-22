//https://leetcode.com/problems/wildcard-matching/

//Simple DP

public class Solution {
    public bool IsMatch(string s, string p) {
        int ls = s.Length;
        int lp = p.Length;
        bool[,] dp = new bool[ls+1, lp+1];
        dp[ls,lp] = true;
        for(int i=lp-1; i>=0; i--){
            if(p[i] !='*')
                break;
            else
                dp[ls, i]=true;
        }
        for(int i = ls-1; i >=0; i--){
            for(int j = lp-1; j >= 0; j--){
                if(s[i] == p[j] || p[j] == '?') dp[i, j] = dp[i+1, j+1];
                else if(p[j] == '*') dp[i, j] = dp[i+1, j] || dp[i, j+1];
            }
        }
        return dp[0, 0];
    }
}
