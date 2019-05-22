//https://leetcode.com/problems/edit-distance/

//DP.

public class Solution {
    public int MinDistance(string word1, string word2) {
        int l1 = word1.Length;
        int l2 = word2.Length;
        int[,] dp = new int[l1+1, l2+1];
        for(int i = 1; i <= l1; i++) dp[i, 0] = i;
        for(int j = 1; j <= l2; j++) dp[0, j] = j;
        for(int i = 1; i <= l1; i++){
            for(int j = 1; j <= l2; j++){
                if(word1[i-1] == word2[j-1]){
                    dp[i,j] = dp[i-1, j-1];
                } else {
                    dp[i,j] = dp[i-1, j-1] + 1;
                    dp[i,j] = Math.Min(dp[i, j], dp[i-1, j] + 1);
                    dp[i,j] = Math.Min(dp[i, j], dp[i, j-1] + 1);
                }
            }
        }
        return dp[l1, l2];
    }
}
