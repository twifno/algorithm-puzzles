//https://leetcode.com/problems/find-minimum-in-rotated-sorted-array-ii/

//Remove the duplicated boundary..

public class Solution {
    public int FindMin(int[] nums) {
        int min = nums[nums.Length-1];
        int boundary = nums[nums.Length-1];
        int left = 0; 
        int right = nums.Length-1;
        while(left <= right && nums[left] == nums[right]) left += 1;
        while(left <= right){
            int mid = left + (right - left)/2;
            int n = nums[mid];
            if(n <= min){
                min = n;
                right = mid - 1;
            } else if(n > boundary) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        return min;
    }
}
