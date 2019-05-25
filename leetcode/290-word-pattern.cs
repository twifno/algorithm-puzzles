//https://leetcode.com/problems/word-pattern/

public class Solution {
    public bool WordPattern(string pattern, string str) {
        string[] words = str.Split();
        if(words.Length != pattern.Length) return false;
        Dictionary<char, string> ps = new Dictionary<char, string>();
        Dictionary<string, char> sp = new Dictionary<string, char>();
        for(int i = 0; i < words.Length; i++){
            char c = pattern[i];
            string word = words[i];
            if(ps.ContainsKey(c)){
                if(ps[c] != word) return false;
                if(!sp.ContainsKey(word)) return false;
                if(sp[word] != c) return false;
            } else if(sp.ContainsKey(word)){
                return false;
            } else {
                sp[word] = c;
                ps[c] = word;
            }
        }
        return true;
    }
}
