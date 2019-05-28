//https://leetcode.com/problems/number-of-longest-increasing-subsequence/

public class Solution {
    public int FindNumberOfLIS(int[] nums) {
        int len = nums.Length;
        int[] dp = new int[len];
        int[] counts = new int[len];
        int max = 0;
        for(int i = 0; i < len; i++){
            dp[i] = 1;
            counts[i] = 1;
            for(int j = 0; j < i; j++){
                if(nums[i] > nums[j]){
                    if(dp[i] <= dp[j]) {
                        dp[i] = dp[j] + 1;
                        counts[i] = counts[j];
                    } else if(dp[i] == dp[j] + 1) {
                        counts[i] += counts[j];
                    }
                }
            }
            //System.Console.WriteLine(dp[i]);
            max = Math.Max(dp[i], max);
        }
        int sum = 0;
        for(int i = 0; i < len; i++){
            if(dp[i] == max) sum += counts[i];
        }
        return sum;
    }
}
