//https://leetcode.com/problems/isomorphic-strings/

//Pay attention that the comparation is Bidirection

public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char, char> dict1 = new Dictionary<char, char>();
        Dictionary<char, char> dict2 = new Dictionary<char, char>();
        if(s.Length != t.Length) return false;
        for(int i = 0; i < s.Length; i++){
            if(dict1.ContainsKey(s[i])){
                if(dict1[s[i]] != t[i]) return false;
                if(!dict2.ContainsKey(t[i])) return false;
                if(dict2[t[i]] != s[i]) return false;
            } else {
                if(dict2.ContainsKey(t[i])) return false;
                dict1[s[i]] = t[i];
                dict2[t[i]] = s[i];
            }
        }
        return true;
    }
}
