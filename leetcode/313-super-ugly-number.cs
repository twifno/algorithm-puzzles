//https://leetcode.com/problems/super-ugly-number/

public class Solution {
    public int NthSuperUglyNumber(int n, int[] primes) {
        int[] dp = new int[n+1];
        int pl = primes.Length;
        int[] pi = new int[pl];
        for(int i = 0; i < pl; i++) pi[i] = 1;
        dp[1] = 1;
        for(int i = 2; i <= n; i++){
            int last = dp[i-1];
            for(int j = 0; j < pl; j++){
                if(dp[pi[j]] * primes[j] <= last) pi[j] += 1;
            }
            int min = Int32.MaxValue;
            for(int j = 0; j < pl; j++){
                min = Math.Min(min, dp[pi[j]] * primes[j]);
            }
            dp[i] = min;
        }
        return dp[n];
    }
}
