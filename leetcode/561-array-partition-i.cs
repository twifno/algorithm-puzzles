//https://leetcode.com/problems/array-partition-i/

public class Solution {
    public int ArrayPairSum(int[] nums) {
        Array.Sort(nums);
        int sum = 0;
        for(int i = 0; i < nums.Length; i++){
            if(i % 2 == 0) sum += nums[i];
        }
        return sum;
    }
}
