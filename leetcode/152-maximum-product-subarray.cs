//https://leetcode.com/problems/maximum-product-subarray/

//Solve by maintaining a min/max array.

public class Solution {
    public int MaxProduct(int[] nums) {
        int[] dpmax = new int[nums.Length+1];
        int[] dpmin = new int[nums.Length+1];
        dpmax[1] = nums[0];
        dpmin[1] = nums[0];
        int max = nums[0];
        for(int i = 2; i <= nums.Length; i++){
            int n1 = nums[i-1];
            int n2 = n1 * dpmax[i-1];
            int n3 = n1 * dpmin[i-1];
            dpmax[i] = Math.Max(Math.Max(n1, n2), n3);
            max = Math.Max(max, dpmax[i]);
            dpmin[i] = Math.Min(Math.Min(n1, n2), n3);
        }
        return max;
    }
}
