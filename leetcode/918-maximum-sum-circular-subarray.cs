//https://leetcode.com/problems/maximum-sum-circular-subarray/

//Case by case.

public class Solution {
    public int MaxSubarraySumCircular(int[] A) {
        int max = Int32.MinValue;
        max = Math.Max(max, MaxOne(A));
        max = Math.Max(max, MaxTwo(A));
        return max;
    }
    
    private int MaxOne(int[] A) {
        int[] dp = new int[A.Length];
        dp[0] = A[0];
        int max = Int32.MinValue;
        for(int i = 1; i < A.Length; i++) {
            if(dp[i-1] > 0) dp[i] = dp[i-1]+A[i];
            else dp[i] = A[i];
            max = Math.Max(dp[i], max);
        }
        return max;
    }
    
    private int MaxTwo(int[] A){
        int[] sums = new int[A.Length];
        int sum = 0;
        for(int i = 0; i < A.Length; i++){
            sum += A[i];
            if(i == 0) sums[i] = sum;
            else sums[i] = Math.Max(sum, sums[i-1]);
        }
        int[] rsums = new int[A.Length];
        sum = 0;
        for(int i = A.Length-1; i >= 0; i--){
            sum += A[i];
            if(i == A.Length-1) rsums[i] = sum;
            else rsums[i] = Math.Max(sum, rsums[i+1]);
        }
        int max = Int32.MinValue;
        for(int i = 1; i < A.Length; i++){
            max = Math.Max(max, sums[i-1] + rsums[i]);
        }
        return max;
    }
}
