//https://leetcode.com/problems/house-robber-ii/

//Case by case - include first node or exclude first node.

public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length == 0) return 0;
        if(nums.Length == 1) return nums[0];
        return Math.Max(Rob(nums, 0, nums.Length-2), Rob(nums, 1, nums.Length-1));
    }
    
    private int Rob(int[] nums, int left, int right){
        if(left > right) return 0;
        if(left == right) return nums[left];
        int[] dp = new int[right+1];
        dp[left] = nums[left];
        dp[left+1] = Math.Max(nums[left], nums[left+1]);
        for(int i = left + 2; i <= right; i++){
            dp[i] = Math.Max(dp[i-1], dp[i-2] + nums[i]);
        }
        return dp[right];
    }
}
