//https://leetcode.com/problems/pascals-triangle/

public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        List<IList<int>> res = new List<IList<int>>();
        List<int> cur = new List<int>();
        if(numRows == 0) return res;
        cur.Add(1);
        res.Add(cur);
        for(int i = 1; i < numRows; i++){
            List<int> newCur = new List<int>();
            newCur.Add(1);
            for(int j = 0; j < cur.Count-1; j++){
                newCur.Add(cur[j] + cur[j+1]);
            }
            newCur.Add(1);
            res.Add(newCur);
            cur = newCur;
        }
        return res;
    }
}
