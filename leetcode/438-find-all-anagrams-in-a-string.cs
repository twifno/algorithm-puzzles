//https://leetcode.com/problems/find-all-anagrams-in-a-string/

//Count characters for anagrams

public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        int count = 0;
        int[] counts = new int[26];
        foreach(char c in p){
            counts[c-'a'] += 1;
            count += 1;
        }
        List<int> res = new List<int>();
        if(s.Length < p.Length) return res;
        for(int i = 0; i < p.Length; i++){
            char c = s[i];
            if(counts[c-'a'] > 0){
                count -= 1;
            } else {
                count += 1;
            }
            counts[c-'a'] -= 1;
        }
        if(count == 0) res.Add(0);
        int pos = p.Length;
        while(pos < s.Length){
            char c = s[pos];
            if(counts[c-'a'] > 0){
                count -= 1;
            } else {
                count += 1;
            }
            counts[c-'a'] -= 1;
            c = s[pos-p.Length];
            if(counts[c-'a'] < 0){
                count -= 1;
            } else {
                count += 1;
            }
            counts[c-'a'] += 1;
            if(count == 0) res.Add(pos-p.Length+1);
            pos += 1;
        }
        return res;
    }
}
