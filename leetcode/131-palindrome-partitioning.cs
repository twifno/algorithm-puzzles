//https://leetcode.com/problems/palindrome-partitioning/

//Back tracking…

public class Solution {
    public IList<IList<string>> Partition(string s) {
        List<IList<string>> res = new List<IList<string>>();
        List<string> cur = new List<string>();
        Part(s, res, cur);
        return res;
    }
    
    public void Part(string s, List<IList<string>> res, List<string> cur){
        if(s.Length == 0) {
            res.Add(new List<string>(cur));
            return;
        }
        for(int i = 1; i <= s.Length; i++){
            string sub = s.Substring(0, i);
            if(IsP(sub)){
                cur.Add(sub);
                Part(s.Substring(i, s.Length-i), res, cur);
                cur.RemoveAt(cur.Count-1);
            }
        }
    }
    
    //Dictionary<string, bool> cache = new Dictionary<string, bool>();
    
    private bool IsP(string s){
        //if(cache.ContainsKey(s)) return cache[s];
        int left = 0;
        int right = s.Length-1;
        while(left < right){
            if(s[left] != s[right]) {
                //cache[s] = false;
                return false;
            }
            left += 1;
            right -= 1;
        }
        //cache[s] = true;
        return true;
    }
}
