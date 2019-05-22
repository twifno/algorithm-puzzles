//https://leetcode.com/problems/implement-strstr/

//Typical KMP

public class Solution {
    public int StrStr(string haystack, string needle) {
        if(string.IsNullOrEmpty(needle)) return 0;
        int[] lps = new int[needle.Length];
        GenLPS(needle, lps);
        int len = 0;
        int cur = 0;
        while(cur < haystack.Length){
            if(haystack[cur] == needle[len]){
                cur += 1;
                len += 1;
            } else if (len == 0){
                cur += 1;  
            } else {
                len = lps[len-1];
            }
            if(len == needle.Length){
                return cur - len;
            }
        }
        return -1;
    }
    
    private void GenLPS(string pattern, int[] lps){
        int len = 0;
        int cur = 1;
        while(cur < pattern.Length){
            if(pattern[cur] == pattern[len]){
                len += 1;
                lps[cur] = len;
                cur += 1;
            } else {
                if(len == 0) cur += 1;
                else len = lps[len-1];
            }
        }
    }
}
