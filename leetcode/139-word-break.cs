//https://leetcode.com/problems/word-break/

//Back tracking… time limit exceed.

public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        Dictionary<string, bool>  cache = new Dictionary<string, bool>();
        foreach(string w in wordDict) cache[w] = true;
        return Break(s, cache);
    }
    
    private bool Break(string s, Dictionary<string, bool> cache){
        if(s == "") return true;
        if(cache.ContainsKey(s)) return cache[s];
        for(int i = 1; i <= s.Length; i++){
            string sub = s.Substring(0, i);
            if(cache.ContainsKey(sub) 
               && cache[sub]
               && Break(s.Substring(i, s.Length-i), cache)) { cache[s] = true; return true; }
        }
        cache[s] = false;
        return false;
    }
}


//DP

public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        HashSet<string> hs = new HashSet<string>();
        foreach(string word in wordDict){
            hs.Add(word);
        }
        bool[] dp = new bool[s.Length+1];
        dp[0] = true;
        for(int i = 1; i <= s.Length; i++){
            for(int j = 1; j <= i; j++){
                if(dp[i-j] && hs.Contains(s.Substring(i-j, j))) {
                    dp[i] = true;
                    break;
                }
            }
        }
        return dp[s.Length];
    }
}

