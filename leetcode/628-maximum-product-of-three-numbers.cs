//https://leetcode.com/problems/maximum-product-of-three-numbers/

public class Solution {
    public int MaximumProduct(int[] nums) {
        Array.Sort(nums);
        return Math.Max(nums[0]*nums[1]*nums[nums.Length-1], nums[nums.Length-1]*nums[nums.Length-2]*nums[nums.Length-3]);
    }
}
