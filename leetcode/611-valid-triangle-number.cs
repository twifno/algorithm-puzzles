//https://leetcode.com/problems/valid-triangle-number/

public class Solution {
    public int TriangleNumber(int[] nums) {
        if(nums.Length < 3) return 0;
        Array.Sort(nums);
        int right = nums.Length - 1;
        int sum = 0;
        while(right >= 2){
            int left = 0;
            int mid = right - 1;
            while(left < right-1){
                if(mid <= left) {
                    if(nums[left] + nums[mid+1] > nums[right]) sum += right - left - 1;
                }else {
                    while(mid > left && nums[mid] + nums[left] > nums[right]) mid -= 1;
                    if(mid > left) sum += right - mid - 1;
                    else if(mid == left && nums[mid+1] + nums[left] > nums[right]) sum += right - left - 1;
                }
                left += 1;
            }
            right -= 1;
        }
        return sum;
    }
}
