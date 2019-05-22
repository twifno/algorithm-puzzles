//https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/

//Two binary search.

public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;
        int[] ret = {-1, -1};
        while (left <= right) {
            int mid = left + (right-left)/2;
            int val = nums[mid];
            if(val == target){
                if(mid == 0 || nums[mid-1] < target) {
                    ret[0] = mid;
                    break;
                } else {
                    right = mid - 1;
                }
            } else if (val > target) right = mid - 1;
            else left = mid + 1;
        }
        if(ret[0] == -1) return ret;
        left = ret[0];
        right = nums.Length - 1;
        while (left <= right) {
            int mid = left + (right-left)/2;
            int val = nums[mid];
            if(val == target){
                if(mid == nums.Length-1 || nums[mid+1] > target) {
                    ret[1] = mid;
                    break;
                } else {
                    left = mid + 1;
                }
            } else if (val > target) right = mid - 1;
            else left = mid + 1;
        }
        return ret;
    }
}
