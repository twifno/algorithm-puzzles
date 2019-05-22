//https://leetcode.com/problems/permutations/

//Use back tracking to list all possible permutation.

public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        IList<IList<int>> res = new List<IList<int>>();
        Dictionary<int, bool> used = new Dictionary<int, bool>();
        foreach(int n in nums) used[n] = false;
        List<int> cur = new List<int>();
        Gen(nums, cur, res, used);
        return res;
    }
    
    private void Gen(int[] nums, List<int> cur, IList<IList<int>> res, Dictionary<int, bool> used){
        if(nums.Length == cur.Count){
            res.Add(new List<int>(cur));
        }
        for(int i = 0; i < nums.Length; i++){
            int val = nums[i];
            if(!used[val]){
                cur.Add(val);
                used[val] = true;
                Gen(nums, cur, res, used);
                cur.RemoveAt(cur.Count-1);
                used[val] = false;
            }
        }
    }
}
