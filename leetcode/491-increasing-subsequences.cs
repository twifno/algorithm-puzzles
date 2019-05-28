//https://leetcode.com/problems/increasing-subsequences/

//How to dedup -> prevent using the same number in the same layer.

public class Solution {
    public IList<IList<int>> FindSubsequences(int[] nums) {
        List<IList<int>> res = new List<IList<int>>();
        List<int> cur = new List<int>();
        Find(nums, cur, 0, res);
        return res;
    }
    
    private void Find(int[] nums, List<int> cur, int pos, List<IList<int>> res){
        HashSet<int> visited = new HashSet<int>();
        if(cur.Count == 0) {
            for(int i = 0; i < nums.Length-1; i++){
                if(visited.Contains(nums[i])) continue;
                visited.Add(nums[i]);
                cur.Add(nums[i]);
                Find(nums, cur, i+1, res);
                cur.RemoveAt(cur.Count-1);
            }
        } else {
            for(int i = pos; i < nums.Length; i++){
                if(visited.Contains(nums[i])) continue;
                visited.Add(nums[i]);
                if(nums[i] >= cur[cur.Count-1]){
                    cur.Add(nums[i]);
                    res.Add(new List<int>(cur));
                    Find(nums, cur, i + 1, res);
                    cur.RemoveAt(cur.Count-1);
                }
            }
        }
    }
}
