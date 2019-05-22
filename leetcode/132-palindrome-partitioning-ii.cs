//https://leetcode.com/problems/palindrome-partitioning-ii/

//DP..
//Palindrome can be precomputed and save in a 2D array.

public class Solution {
    public int MinCut(string s) {
        int[] dp = new int[s.Length+1];
        dp[0] = 0;
        for(int i = 1; i <= s.Length; i++){
            int min = Int32.MaxValue;
            for(int j = i; j > 0; j--){
                if(IsP(s.Substring(i-j, j))) min = Math.Min(min, dp[i-j]+1);
            }
            dp[i] = min;
        }
        return dp[s.Length]-1;
    }
    
    private bool IsP(string s){
        int left = 0;
        int right = s.Length-1;
        while(left < right){
            if(s[left] != s[right]) {
                return false;
            }
            left += 1;
            right -= 1;
        }
        return true;
    }
}
