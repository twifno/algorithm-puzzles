//https://leetcode.com/problems/3sum-smaller/

//Sort and two points approach.

public class Solution {
    public int ThreeSumSmaller(int[] nums, int target) {
        int count = 0;
        Array.Sort(nums);
        for(int i = 0; i < nums.Length - 2; i++){
            count += TwoSumSmaller(nums, i+1, target-nums[i]);
        }
        return count;
    }
    
    private int TwoSumSmaller(int[] nums, int start, int target){
        int left = start;
        int right = start+1;
        if(nums[left] + nums[right] >= target) return 0;
        int count = 0;
        while(right < nums.Length && nums[left] + nums[right] < target) right += 1;
        right -= 1;
        while(left < right){
            count += right - left;
            left += 1;
            while(nums[left] + nums[right] >= target) right -= 1;
        }
        return count;
    }
}
