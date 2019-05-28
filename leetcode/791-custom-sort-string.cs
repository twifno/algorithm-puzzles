//https://leetcode.com/problems/custom-sort-string/

public class Solution {
    public string CustomSortString(string S, string T) {
        int[] counts = new int[26];
        foreach(char c in T) counts[c-'a'] += 1;
        StringBuilder sb = new StringBuilder();
        foreach(char c in S) {
            int idx = c-'a';
            sb.Append(new string(c, counts[idx]));
            counts[idx] = 0;
        }
        for(int i = 0; i < 26; i++){
            int n = counts[i];
            sb.Append(new string((char)('a'+i), n));
        }
        return sb.ToString();
    }
}
