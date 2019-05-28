//https://leetcode.com/problems/reorganize-string/

public class Solution {
    public string ReorganizeString(string S) {
        int len = S.Length;
        int[] counts = new int[26];
        int max = 0;
        foreach(char c in S){
            counts[c-'a'] += 1;
            max = Math.Max(max, counts[c-'a']);
        }
        if(max > (S.Length+1)/2) return "";
        char[] cs = S.ToCharArray();
        Array.Sort(cs, delegate(char x, char y) {
            if(counts[x-'a'] != counts[y-'a']) return counts[x-'a'].CompareTo(counts[y-'a']);
            return x.CompareTo(y);
        });
        char[] newCs = new char[cs.Length];
        int cur = 0;
        int i = 0, j = cs.Length/2;
        while(cur < cs.Length){
            newCs[cur] = cs[j];
            cur += 1;
            j += 1;
            if(cur < cs.Length){
                newCs[cur] = cs[i];
                cur += 1;
                i += 1;
            }
        }
        return new string(newCs);
    }
}
