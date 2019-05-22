//https://leetcode.com/problems/permutations-ii/

//Back tracking - no repeat number in the same loop.

public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
        IList<IList<int>> res = new List<IList<int>>();
        Dictionary<int, int> used = new Dictionary<int, int>();
        foreach(int n in nums) {
            if(used.ContainsKey(n)) used[n] += 1;
            else used[n] = 1;
        }
        List<int> cur = new List<int>();
        Array.Sort(nums);
        Gen(nums, cur, res, used);
        return res;
    }
    
    private void Gen(int[] nums, List<int> cur, IList<IList<int>> res, Dictionary<int, int> used){
        if(nums.Length == cur.Count){
            res.Add(new List<int>(cur));
        }
        
        for(int i = 0; i < nums.Length; i++){
            int val = nums[i];
            if(used[val] > 0){
                cur.Add(val);
                used[val] -= 1;
                Gen(nums, cur, res, used);
                cur.RemoveAt(cur.Count-1);
                used[val] += 1;
                while(i+1 < nums.Length && nums[i+1] == val) i += 1;
            }
        }
    }
}
