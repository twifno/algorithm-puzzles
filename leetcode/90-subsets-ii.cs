//https://leetcode.com/problems/subsets-ii/

//Back tracking …

public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        IList<IList<int>> res = new List<IList<int>>();
        List<int> cur = new List<int>();
        Array.Sort(nums);
        Find(nums, 0, res, cur);
        return res;
        
    }
    
    private void Find(int[] nums, int start, IList<IList<int>> res, List<int> cur){
        if(start == nums.Length) res.Add(new List<int>(cur));
        else {
            int val = nums[start];
            int end = start;
            while(end < nums.Length && nums[end] == val) end += 1;
            Find(nums, end, res, cur);
            for(int i = start; i < end; i++){
                cur.Add(val);
                Find(nums, end, res, cur);
            }
            for(int i = start; i < end; i ++){
                cur.RemoveAt(cur.Count-1);
            }
        }
    }
}
