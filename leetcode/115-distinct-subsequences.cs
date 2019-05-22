//https://leetcode.com/problems/distinct-subsequences/

//Back tracking - very slow

public class Solution {
    Dictionary<string, int> Cache = new Dictionary<string, int>();
    
    public int NumDistinct(string s, string t) {
        if(s.Length < t.Length) return 0;
        if(s == t) return 1;
        if(s.Length == t.Length) return 0;
        if(t.Length == 0) return 1;
        string k = s+":"+t;
        if(Cache.ContainsKey(k)) return Cache[k];
        int count = 0;
        for(int i = 0; i <= s.Length-t.Length; i++){
            if(s[i] == t[0]) count += NumDistinct(s.Substring(i+1, s.Length-i-1), t.Substring(1, t.Length-1));
        }
        Cache[k] = count;
        return count;
    }
}
