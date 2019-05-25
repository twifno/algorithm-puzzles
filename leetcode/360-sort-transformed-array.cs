//https://leetcode.com/problems/sort-transformed-array/

//Based on the characteristic of a quadratic function, smallest number will be on the end.

public class Solution {
    public int[] SortTransformedArray(int[] nums, int a, int b, int c) {
        for(int i = 0; i < nums.Length; i++) nums[i] = a*nums[i]*nums[i] + b*nums[i] + c;
        if(a == 0) {
            if(b >= 0) return nums;
            else {
                Array.Reverse(nums);
                return nums;
            }
        }
        int[] res = new int[nums.Length];
        if(a > 0){
            int left = 0; int right = nums.Length-1;
            for(int i = 0; i< nums.Length; i++){
                if(nums[left] > nums[right]){
                    res[i] = nums[left];
                    left += 1;
                } else {
                    res[i] = nums[right];
                    right -= 1;
                }
            }
            Array.Reverse(res, 0, res.Length);
            
        } else {
            int left = 0; int right = nums.Length-1;
            for(int i = 0; i< nums.Length; i++){
                if(nums[left] < nums[right]){
                    res[i] = nums[left];
                    left += 1;
                } else {
                    res[i] = nums[right];
                    right -= 1;
                }
            }
        }
        return res;
    }
}
