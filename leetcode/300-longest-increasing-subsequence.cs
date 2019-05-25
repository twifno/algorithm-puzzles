//https://leetcode.com/problems/longest-increasing-subsequence/

public class Solution {
    public int LengthOfLIS(int[] nums) {
        int len = nums.Length;
        if(len == 0) return 0;
        int[] dp = new int[len];
        dp[0] = 1;
        int gm = 1;
        for(int i = 1; i < len; i++){
            int max = 0;
            for(int j = 0; j < i; j++){
                if(nums[i] > nums[j]) max = Math.Max(max, dp[j]);
            }
            dp[i] = max + 1;
            gm = Math.Max(dp[i], gm);
        }
        return gm;
    }
}
