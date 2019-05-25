//https://leetcode.com/problems/summary-ranges/

public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        List<string> res = new List<string>();
        if(nums.Length == 0) return res;
        int start = 0;
        int end = 0;
        for(int i = 1; i < nums.Length; i++){
            if(nums[i] == nums[i-1]+1) end = i;
            else {
                if(start == end) res.Add(nums[start].ToString());
                else res.Add(nums[start].ToString()+"->"+nums[end]);
                start = i;
                end = i;
            }
        }
        if(start == end) res.Add(nums[start].ToString());
        else res.Add(nums[start].ToString()+"->"+nums[end]);
        return res;
    }
}
