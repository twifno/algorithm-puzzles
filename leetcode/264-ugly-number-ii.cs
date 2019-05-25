//https://leetcode.com/problems/ugly-number-ii/

//DP

public class Solution {
    public int NthUglyNumber(int n) {
        int[] dp = new int[n+1];
        dp[1] = 1;
        int l2 = 1;
        int l3 = 1;
        int l5 = 1;
        for(int i = 2; i <= n; i++){
            int last = dp[i-1];
            while(dp[l2]*2 <= last) l2+=1;
            while(dp[l3]*3 <= last) l3+=1;
            while(dp[l5]*5 <= last) l5+=1;
            if(dp[l2]*2 <= dp[l3]*3 && dp[l2]*2 <= dp[l5]*5) {
                dp[i] = dp[l2]*2; 
                l2 += 1;
                
            } else if(dp[l3]*3 <= dp[l5]*5) {
                dp[i] = dp[l3]*3; 
                l3 += 1;
            } else {
                dp[i] = dp[l5]*5; 
                l5 += 1;
            }
            //System.Console.WriteLine(dp[i]);
        }
        return dp[n];
    }
}
