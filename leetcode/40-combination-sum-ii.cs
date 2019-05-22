//https://leetcode.com/problems/combination-sum-ii/

public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        IList<IList<int>> res = new List<IList<int>>();
        Array.Sort(candidates);
        if(candidates.Length == 0) return res;
        Dictionary<int, int> counts = new Dictionary<int, int>();
        foreach(int i in candidates){
            if(counts.ContainsKey(i)) counts[i] += 1;
            else counts[i] = 1;
        }
        List<int> cur = new List<int>();
        Find(candidates, 0, cur, target, 0, res, counts);
        return res;
    }
    
    private void Find(int[] c, int pos, List<int> cur, int target, int acc, IList<IList<int>> res, Dictionary<int, int> counts){
        if(pos >= c.Length) return;
        if(c[pos] > target - acc) return;
        Find(c, pos+1, cur, target, acc, res, counts);
        if(pos > 0 && c[pos] == c[pos-1]) return;
        for(int i = 1; i*c[pos]+acc <= target && i <= counts[c[pos]]; i++){
            cur.Add(c[pos]);
            if(i*c[pos]+acc == target) res.Add(new List<int>(cur));
            else Find(c, pos+1, cur, target, acc+i*c[pos], res, counts);
        }
        while(cur.Count>0 && cur[cur.Count-1] == c[pos]) {cur.RemoveAt(cur.Count-1);}
    }
}
