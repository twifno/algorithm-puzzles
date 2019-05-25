//https://leetcode.com/problems/maximum-size-subarray-sum-equals-k/

public class Solution {
    public int MaxSubArrayLen(int[] nums, int k) {
        Dictionary<int, int> sums = new Dictionary<int, int>();
        sums[0] = -1;
        int sum = 0;
        int max = 0;
        for(int i = 0; i < nums.Length; i++){
            sum += nums[i];
            if(sums.ContainsKey(sum - k)) max = Math.Max(max, i-sums[sum-k]);
            if(!sums.ContainsKey(sum)) sums[sum] = i;
        }
        return max;
    }
}
