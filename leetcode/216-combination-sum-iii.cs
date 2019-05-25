//https://leetcode.com/problems/combination-sum-iii/

//Normal back tracking..

public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        List<IList<int>> res = new List<IList<int>>();
        if(k > 9) return res;
        if(n > 45) return res;
        List<int> cur = new List<int>();
        Find(1, 1, 0, cur, res, k, n);
        return res;
    }
    
    private void Find(int step, int start, int sum, List<int> cur, List<IList<int>> res, int k, int n){
        if(step > k && sum != n) return;
        if(step > k && sum == n) { res.Add(new List<int>(cur)); return;}
        for(int i = start; i <= 9-k+step; i++){
            if(sum + i > n) return;
            cur.Add(i);
            Find(step+1, i+1, sum+i, cur, res, k, n);
            cur.RemoveAt(cur.Count-1);
        }
    }
}
