//https://leetcode.com/problems/split-array-with-equal-sum/

public class Solution {
    Dictionary<string, bool> Cache;
    
    public bool SplitArray(int[] nums) {
        Cache = new Dictionary<string, bool>();
        int sum = 0;
        int pos = 0;
        while(pos < nums.Length){
            sum += nums[pos];
            if(SplitArray(nums, pos + 2, 2, sum)) return true; 
            pos += 1;
        }
        return false;
    }
    
    public bool SplitArray(int[] nums, int pos, int step, int val){
        int sum = 0;
        if(pos >= nums.Length) return false;
        string key = string.Format("{0}:{1}:{2}", pos, step, val);
        if(Cache.ContainsKey(key)) return Cache[key];
        if(step == 0) {         
            for(int i = pos; i < nums.Length; i++) sum += nums[i];
            if(sum == val) { Cache[key] = true; return true; }
            Cache[key] = false;
            return false;
        }
        while(pos < nums.Length){
            sum += nums[pos];
            if(sum == val && SplitArray(nums, pos + 2, step - 1, val)) { Cache[key] = true; return true; }
            pos += 1;
        }
        Cache[key] = false;
        return false;
    }
}
