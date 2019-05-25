//https://leetcode.com/problems/word-pattern-ii/

public class Solution {
    public bool WordPatternMatch(string pattern, string str) {
        Dictionary<char, string> p2s = new Dictionary<char, string>();
        Dictionary<string, char> s2p = new Dictionary<string, char>();
        return Match(pattern, 0, str, 0, p2s, s2p);
    }
    
    private bool Match(string p, int lp, string s, int ls, Dictionary<char, string> p2s, Dictionary<string, char> s2p){
        if(lp == p.Length && ls == s.Length) return true;
        if(lp == p.Length || ls == s.Length) return false;
        char pc = p[lp];
        if(p2s.ContainsKey(pc)) {
            int idx = s.IndexOf(p2s[pc], ls);
            if(idx == ls) return Match(p, lp+1, s, ls+p2s[pc].Length, p2s, s2p);
            return false;
        } else {
            for(int i = ls; i < s.Length; i++){
                string sub = s.Substring(ls, i-ls+1);
                if(s2p.ContainsKey(sub)) continue;
                p2s[pc] = sub;
                s2p[sub] = pc;
                if(Match(p, lp+1, s, ls+sub.Length, p2s, s2p)) return true;
                p2s.Remove(pc);
                s2p.Remove(sub);
            }
            return false;
        }
    }
}
