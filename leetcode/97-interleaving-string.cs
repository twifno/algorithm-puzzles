//https://leetcode.com/problems/interleaving-string/

//DP.. It can be solved by DFS and BFS too.
public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        int l1 = s1.Length;
        int l2 = s2.Length;
        int l3 = s3.Length;
        if(l1 + l2 != l3) return false;
        bool[,] dp = new bool[l1+1, l2+1];
        dp[0,0] = true;
        for(int i = 1; i <= l1; i++){
            if(dp[i-1, 0] == true && s1[i-1] == s3[i-1]) dp[i,0] = true;
            else break;
        }
        for(int j = 1; j <= l2; j++){
            if(dp[0, j-1] == true && s2[j-1] == s3[j-1]) dp[0,j] = true;
            else break;
        }
        for(int i = 1; i <= l1; i++) {
            for(int j = 1; j <= l2; j++){
                if(s1[i-1] == s3[i+j-1] && dp[i-1,j] == true) dp[i,j] = true;
                else if(s2[j-1] == s3[i+j-1] && dp[i,j-1] == true) dp[i,j] = true;
            }
        }
        return dp[l1,l2];
    }
}
