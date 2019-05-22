//https://leetcode.com/problems/jump-game-ii/

//Super smart greedy algorithm… 

public class Solution {
    public int Jump(int[] nums) {
        if(nums.Length <= 1) return 0;
        int cur = 0;
        int tail = nums[cur];
        int count = 1;
        while(tail < nums.Length-1){
            int newTail = tail;
            while(cur <= tail){
                newTail = Math.Max(newTail, cur+nums[cur]);
                cur += 1;
            }
            tail = newTail;
            count += 1;
        }
        return count;
    }
}
