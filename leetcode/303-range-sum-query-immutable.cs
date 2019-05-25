//https://leetcode.com/problems/range-sum-query-immutable/

public class NumArray {

    int[] sums;
    
    public NumArray(int[] nums) {
        int sum = 0;
        sums = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++){
            sum += nums[i];
            sums[i] = sum;
        }
    }
    
    public int SumRange(int i, int j) {
        if(i == 0) return sums[j];
        return sums[j] - sums[i-1];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(i,j);
 */
