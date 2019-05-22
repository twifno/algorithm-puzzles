//https://leetcode.com/problems/search-in-rotated-sorted-array-ii/

//Remove the duplicate end

public class Solution {
    public bool Search(int[] nums, int target) {
        if(nums.Length == 0) return false;
        if(nums[0] == target) return true;
        int left = 0;
        int right = nums.Length-1;
        while(left < right){
            if(nums[left] == nums[right] && nums[left] == nums[0]) {
                left += 1;
                right -= 1;
            } else {
                break;
            }
        }
        if(left == right) return nums[left] == target;
        while(left <= right){
            int mid = left + (right - left)/2;
            if(nums[mid] == target) return true;
            if(nums[mid] < target) {
                if(nums[mid] >= nums[left]) left = mid + 1;
                else if(target >= nums[left]) right = mid - 1;
                else left = mid + 1;
            } else {
                if(nums[mid] <= nums[right]) right = mid - 1;
                else if(target >= nums[left]) right = mid - 1;
                else left = mid + 1;
            }
        }
        return false;
    }
}
