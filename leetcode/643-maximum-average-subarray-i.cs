//https://leetcode.com/problems/maximum-average-subarray-i/

public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double[] sums = new double[nums.Length];
        double sum = 0;
        double max = double.MinValue;
        for(int i = 0; i < nums.Length; i++){
            sum += nums[i];
            sums[i] = sum;
            if(i >= k-1) {
                max = Math.Max(max, (i==k-1)?(sum/k):(sums[i] - sums[i-k])/k);
            }
        }
        return max;
    }
}
