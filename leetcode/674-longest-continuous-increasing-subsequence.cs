//https://leetcode.com/problems/longest-continuous-increasing-subsequence/

public class Solution {
    public int FindLengthOfLCIS(int[] nums) {
        if(nums.Length == 0) return 0;
        int max = 1;
        int cur = 1;
        for(int i = 1; i < nums.Length; i++){
            if(nums[i] > nums[i-1]){
                cur += 1;
                max = Math.Max(cur, max);
            } else {
                cur = 1;
            }
        }
        return max;
    }
}
