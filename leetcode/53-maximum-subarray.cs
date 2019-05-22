//https://leetcode.com/problems/maximum-subarray/

//Simple DP…

public class Solution {
    public int MaxSubArray(int[] nums) {
        int[] maxend = new int[nums.Length];
        int max = nums[0];
        maxend[0] = nums[0];
        for(int i = 1; i < nums.Length; i++){
            maxend[i] = Math.Max(nums[i], nums[i] + maxend[i-1]);
            max = Math.Max(maxend[i], max);
        }
        return max;
    }
}
