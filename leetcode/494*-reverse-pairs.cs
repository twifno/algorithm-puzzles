//https://leetcode.com/problems/reverse-pairs/

//Consider the case that non of the number is selected.

public class Solution {
    public int FindTargetSumWays(int[] nums, int S) {
        int sum = 0;
        foreach (int n in nums) sum += n;
        if((sum + S)%2 != 0) return 0;
        return Find(nums, (sum+(int)Math.Abs(S))/2, 0) + (((sum == 0) && (S == 0))?1:0);
    }
    
    private int Find(int[] nums, int target, int pos){
        int sum = 0;
        for(int i = pos; i < nums.Length; i++){
            if(target == nums[i]) sum += 1 + Find(nums, 0, i+1);
            else if(target > nums[i]) sum += Find(nums, target-nums[i], i+1);
        }
        return sum;
    }
}
