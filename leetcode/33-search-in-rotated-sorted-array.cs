//https://leetcode.com/problems/search-in-rotated-sorted-array/

//Binary Search with special handling on two ends.

public class Solution {
    public int Search(int[] nums, int target) {
        if(nums.Length == 0) return -1;
        int left = 0;
        int right = nums.Length - 1;
        int lend = nums[0];
        int rend = nums[nums.Length-1];
        while(left <= right){
            int mid = left + (right-left)/2;
            int val = nums[mid];
            if(val == target) return mid;
            else if (val < target) {
                if(val >= lend) left = mid + 1;
                else if(target <= rend) left = mid + 1;
                else right = mid - 1;
            } else {
                if(val <= rend) right = mid - 1;
                else if (target >= lend) right = mid - 1;
                else left = mid + 1;
            }
        }
        return -1;
    }
}
