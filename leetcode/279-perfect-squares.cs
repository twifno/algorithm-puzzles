//https://leetcode.com/problems/perfect-squares/

public class Solution {
    public int NumSquares(int n) {
        List<int> ps = new List<int>();
        for(int i = 1; i <= n; i++){
            if(i * i <= n) ps.Add(i*i);
            else break;
        }
        int[] dp = new int[n+1];
        for(int i = 1; i <= n; i++){
            int min = Int32.MaxValue;
            foreach(int psn in ps){
                if(psn <= i) min = Math.Min(min, dp[i-psn] + 1);
            }
            dp[i] = min;
        }
        return dp[n];
    }
}
