//https://leetcode.com/problems/subarray-sum-equals-k/

public class Solution {
    public int SubarraySum(int[] nums, int k) {
        Dictionary<int, int> sums = new Dictionary<int, int>();
        int count = 0;
        sums[0] = 1;
        int sum = 0;
        foreach(int n in nums){
            sum += n;
            if(sums.ContainsKey(sum-k)) count += sums[sum-k];
            if(!sums.ContainsKey(sum)) sums[sum] = 1;
            else sums[sum] += 1;
        }
        return count;
    }
}
