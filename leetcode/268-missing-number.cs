//https://leetcode.com/problems/missing-number/

//Can also be solved by XOR or Math

public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length;
        for(int i = 0; i < n; i++){
            while(nums[i] != i && nums[i] != n){
                int val = nums[i];
                nums[i] = nums[val];
                nums[val] = val;
            }
        }
        for(int i = 0; i < n; i++){
            if(nums[i] != i) return i;
        }
        return n;
    }
}
