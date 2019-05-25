//https://leetcode.com/problems/product-of-array-except-self/

//Two pass updating

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] res = new int[nums.Length];
        for(int i = 0; i < res.Length; i++) res[i] = 1;
        int b = 1;
        for(int i = 1; i < res.Length; i++) {
            b *= nums[i-1];
            res[i] *= b;
        }
        b = 1;
        for(int i = res.Length-2; i >= 0; i--){
            b *= nums[i+1];
            res[i] *= b;
        }
        return res;
    }
}
