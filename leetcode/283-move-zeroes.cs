//https://leetcode.com/problems/move-zeroes/

public class Solution {
    public void MoveZeroes(int[] nums) {
        int cur = 0;
        for(int i = 0; i < nums.Length; i++){
            while(cur < nums.Length && nums[cur] == 0) cur+=1;
            if(cur == nums.Length) return;
            if(nums[i] == 0) {
                nums[i] = nums[cur];
                nums[cur] = 0;
            } else {
                cur += 1;
            }
        }
    }
}
