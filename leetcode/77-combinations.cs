//https://leetcode.com/problems/combinations/

//Back tracking..

public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        List<IList<int>> res = new List<IList<int>>();
        List<int> cur = new List<int>();
        Gen(n, k, 1, res, cur);
        return res;
    }
    
    private void Gen(int n, int k, int s, List<IList<int>> res, List<int> cur){
        if(cur.Count == k) { res.Add(new List<int>(cur)); return; }
        if(s > n) return;
        for(int i = s; i <= n; i++){
            cur.Add(i);
            Gen(n, k, i+1, res, cur);
            cur.RemoveAt(cur.Count-1);
        }
    }
}
