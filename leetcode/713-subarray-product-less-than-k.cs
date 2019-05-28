//https://leetcode.com/problems/subarray-product-less-than-k/

//Be care of overflow.

public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        if(k <= 1) return 0;
        if(nums.Length == 0) return 0;
        int pro = nums[0];
        int left = 0;
        int right = 0;
        int count = 0;
        while(right < nums.Length){
            if(pro < k){
                count += right-left+1;
                right += 1;
                if(right < nums.Length) pro *= nums[right];
            } else {
                pro /= nums[left];
                left += 1;
            }
        }
        return count;
    }
}
