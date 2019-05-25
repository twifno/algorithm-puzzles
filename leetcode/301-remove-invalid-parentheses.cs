//https://leetcode.com/problems/remove-invalid-parentheses/

//Smart backing tracking

public class Solution {
    public IList<string> RemoveInvalidParentheses(string s) {
        List<string> half = new List<string>();
        Remove(s, 0, 0, '(', ')', half);
        List<string> full = new List<string>();
        foreach(string h in half) {
            Remove(Reverse(h), 0, 0, ')', '(', full);
        }
        List<string> res = new List<string>();
        foreach(string f in full) res.Add(Reverse(f));
        return res;
    }
    
    private string Reverse(string s){
        char[] cs = s.ToCharArray();
        Array.Reverse(cs);
        return new string(cs);
    }
    
    private void Remove(string s, int start, int lastRemove, char lkey, char rkey, List<string> res){
        int left = 0;
        int right = 0;
        for(int i = start; i < s.Length; i++){
            if(s[i] == lkey) left += 1;
            if(s[i] == rkey) right += 1;
            if(right > left){
                for(int j = lastRemove; j <= i; j++){
                    if(s[j] == rkey && (j == lastRemove || s[j-1] != rkey)) {
                        Remove(s.Substring(0, j)+s.Substring(j+1, s.Length-j-1), i, j, lkey, rkey, res);
                    }
                }
                return;
            }
        }
        //System.Console.WriteLine(s);
        res.Add(s);
    }
}
