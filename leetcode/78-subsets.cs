//https://leetcode.com/problems/

//Back tracking.

public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        List<IList<int>> res = new List<IList<int>>();
        List<int> cur = new List<int>();
        Gen(nums, 0, res, cur);
        return res;
    }
    
    private void Gen(int[] nums, int k, IList<IList<int>> res, List<int> cur){
        if(k >= nums.Length) res.Add(new List<int>(cur));
        else {
            Gen(nums, k+1, res, cur);
            cur.Add(nums[k]);
            Gen(nums, k+1, res, cur);
            cur.RemoveAt(cur.Count-1);
        }
    }
}
