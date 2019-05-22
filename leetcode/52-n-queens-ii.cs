//https://leetcode.com/problems/

//Nothing different than the N-Queens I

public class Solution {
    public int TotalNQueens(int n) {
        IList<IList<string>> res = new List<IList<string>>();
        if(n == 0) return 0;
        IList<string> cur = new List<string>();
        Find(n, cur, res);
        return res.Count;
    }
    
    private void Find(int n, IList<string> cur, IList<IList<string>> res){
        if(cur.Count == n) res.Add(new List<string>(cur));
        else {
            char[] row = new char[n];
            int r = cur.Count;
            for(int i = 0; i < n; i++) row[i] = '.';
            for(int i = 0; i < n; i++) {
                if(Check(r, i, cur)){
                    row[i] = 'Q';
                    cur.Add(string.Join("",row));
                    Find(n, cur, res);
                    row[i] = '.';
                    cur.RemoveAt(cur.Count-1);
                }
            }
        }
    }
    
    private bool Check(int r, int c, IList<string> cur){
        for(int i = 0; i < r; i++){
            if(cur[i][c] == 'Q') return false;
            if(c-r+i >= 0 && cur[i][c-r+i] == 'Q') return false;
            if(c+r-i < cur[0].Length && cur[i][c+r-i] == 'Q') return false;
        }
        return true;
    }
}

