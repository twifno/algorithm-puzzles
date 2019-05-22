//https://leetcode.com/problems/search-insert-position/

//Simple binary search

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int left = 0;
        int right = nums.Length-1;
        while(left <= right){
            int mid = left + (right - left)/2;
            int val = nums[mid];
            if(val == target) return mid;
            else if (val < target) left = mid + 1;
            else right = mid - 1;
        }
        return left;
    }
}
