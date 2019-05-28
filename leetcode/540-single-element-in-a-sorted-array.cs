//https://leetcode.com/problems/single-element-in-a-sorted-array/

public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        int left = 0;
        int right = nums.Length-1;
        while(left <= right){
            int mid = left + (right-left)/2;
            if((mid == 0 || nums[mid-1] != nums[mid]) && (mid == nums.Length-1 || nums[mid+1] != nums[mid])) return nums[mid];
            else {
                if(mid % 2 == 1){
                    if(nums[mid] == nums[mid+1]) right = mid-1;
                    else left = mid + 1;
                } else {
                    if(mid == 0) left = mid + 2;
                    else if(mid == nums.Length-1) right = mid - 2;
                    else if(nums[mid] == nums[mid+1]) left = mid + 2;
                    else right = mid - 2;
                }
            }
        }
        return left;
    }
}
