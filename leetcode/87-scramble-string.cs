//https://leetcode.com/problems/scramble-string/

//Recursion and cache…

public class Solution {
    Dictionary<string, bool> cache = new Dictionary<string, bool>();
    
    public bool IsScramble(string s1, string s2) {
        if(s1 == s2) return true;
        string key = s1+s2;
        if(cache.ContainsKey(key)) return cache[key];
        for(int i = 1; i < s1.Length; i++){
            if(IsScramble(s1.Substring(0,i), s2.Substring(0,i)) 
              && IsScramble(s1.Substring(i, s1.Length-i), s2.Substring(i, s2.Length-i))) {  
                cache[key] = true;
                return true;
            }
            else if(IsScramble(s1.Substring(0,i), s2.Substring(s2.Length-i, i)) 
              && IsScramble(s1.Substring(i, s1.Length-i), s2.Substring(0, s2.Length-i))) {
                cache[key] = true;
                return true;
            }
        }
        cache[key] =false;
        return false;
    }
}
