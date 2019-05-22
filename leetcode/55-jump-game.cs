//https://leetcode.com/problems/jump-game/

//Again simple DP

public class Solution {
    public bool CanJump(int[] nums) {
        if(nums.Length <= 1) return true;
        int cur = 0;
        int tail = nums[0];
        while(tail < nums.Length-1 && cur < tail){
            cur += 1;
            tail = Math.Max(tail, nums[cur]+cur);
        }
        return tail >= nums.Length-1;
    }
}

