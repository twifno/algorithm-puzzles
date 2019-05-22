//https://leetcode.com/problems/restore-ip-addresses/

public class Solution {
    public IList<string> RestoreIpAddresses(string s) {
        IList<string> res = new List<string>();
        IList<string> cur = new List<string>();
        Find(s, 1, cur, res);
        return res;
    }
    
    private void Find(string s, int step, IList<string> cur, IList<string> res){
        if(s.Length == 0 && step == 5){
            res.Add(string.Join(".", cur));
        }
        if(step == 5) return;
        if(s.Length == 0) return;
        for(int i = 1; i <= 3 && i <= s.Length; i++){
            if(s[0] == '0' && i > 1) continue;
            string next = s.Substring(0, i);
            int n = Int32.Parse(next);
            if(n <= 255) {
                cur.Add(next);
                Find(s.Substring(i, s.Length-i), step + 1, cur, res);
                cur.RemoveAt(cur.Count-1);
            }
        }
    }
}
