//https://leetcode.com/problems/rotate-function/

//dp[i] = sum - A.Length * A[A.Length-i] + dp[i-1];

public class Solution {
    public int MaxRotateFunction(int[] A) {
        if(A.Length <= 1) return 0;
        int f0 = 0, sum = 0;
        for(int i = 0; i < A.Length; i++){
            sum += A[i];
            f0 += i * A[i];
        }
        int max = f0;
        int[] dp = new int[A.Length];
        dp[0] = f0;
        for(int i = 1; i < A.Length; i++){
            dp[i] = sum - A.Length * A[A.Length-i] + dp[i-1];
            max = Math.Max(max, dp[i]);
        }
        return max;
    }
}
