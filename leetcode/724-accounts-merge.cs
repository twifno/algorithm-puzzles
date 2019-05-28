//https://leetcode.com/problems/accounts-merge/

public class Solution {
    public int PivotIndex(int[] nums) {
        int sum = 0;
        foreach(int n in nums) sum += n;
        int cur = 0;
        for(int i = 0; i < nums.Length; i++){
            if(cur * 2 + nums[i] == sum) return i;
            cur += nums[i];
        }
        return -1;
    }
}
