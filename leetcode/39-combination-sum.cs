//https://leetcode.com/problems/combination-sum/

//Regular back tracking.

public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        IList<IList<int>> res = new List<IList<int>>();
        Array.Sort(candidates);
        if(candidates.Length == 0) return res;   
        List<int> cur = new List<int>();
        Find(candidates, 0, cur, target, 0, res);
        return res;
    }
    
    private void Find(int[] c, int pos, List<int> cur, int target, int acc, IList<IList<int>> res){
        if(pos >= c.Length) return;
        if(c[pos] > target - acc) return;
        Find(c, pos+1, cur, target, acc, res);
        for(int i = 1; i*c[pos]+acc <= target; i++){
            cur.Add(c[pos]);
            if(i*c[pos]+acc == target) res.Add(new List<int>(cur));
            else Find(c, pos+1, cur, target, acc+i*c[pos], res);
        }
        while(cur.Count>0 && cur[cur.Count-1] == c[pos]) {cur.RemoveAt(cur.Count-1);}
    }
}
