//https://leetcode.com/problems/largest-divisible-subset/

public class Solution {
    public IList<int> LargestDivisibleSubset(int[] nums) {
        List<int> res = new List<int>();
        if(nums.Length == 0) return res;
        Array.Sort(nums);
        int[] dp = new int[nums.Length];
        int[] last = new int[nums.Length];
        int max = 1;
        int maxIdx = 0;
        dp[0] = 1;
        last[0] = -1;
        for(int i = 1; i < nums.Length; i++){
            int localmax = 1;
            last[i] = -1;
            for(int j = 0; j < i; j++){
                if(nums[i] % nums[j] == 0){
                    int size = dp[j] + 1;
                    if(size > localmax){
                        last[i] = j;
                        localmax = size;
                    }
                }
            }
            dp[i] = localmax;
            if(localmax > max){
                max = localmax;
                maxIdx = i;
            }
        }
        res.Add(nums[maxIdx]);
        int index = maxIdx;
        while(last[index] != -1){
            index = last[index];
            res.Add(nums[index]);
        }
        return res;
    }
}
