//https://leetcode.com/problems/combination-sum-iv/

//Back tracking …

public class Solution {
    Dictionary<int, int> Cache = new Dictionary<int, int>();
    public int CombinationSum4(int[] nums, int target) {
        if(target == 0) return 1;
        if(Cache.ContainsKey(target)) return Cache[target];
        int count = 0;
        foreach(int n in nums){
            if(n <= target) count += CombinationSum4(nums, target - n);
        }
        Cache[target] = count;
        return count;
    }
}
