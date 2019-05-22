//https://leetcode.com/problems/longest-palindromic-substring/

//Search from the center, handle even odd palindromic separate

public class Solution {
    public string LongestPalindrome(string s) {
        int max = 0;
        string lps = "";
        for(int i = 0; i < s.Length; i++){
            int len = FindOdd(i, s);
            if(len > max) {
                max = len;
                lps = s.Substring(i - len/2, len);
            }
            len = FindEven(i, s);
            if(len > max) {
                max = len;
                lps = s.Substring(i - len/2 + 1, len);
            }
        }
        return lps;
    }
    
    private int FindOdd(int pos, string s) {
        int len = 1;
        int offset = 1;
        while(pos + offset < s.Length && pos - offset >= 0){
            if(s[pos+offset] == s[pos-offset]) len += 2;
            else return len;
            offset += 1;
        }
        return len;
    }
    
    private int FindEven(int pos, string s) {
        int len = 0;
        int offset = 0;
        while(pos + 1 + offset < s.Length && pos - offset >= 0){
            if(s[pos+1+offset] == s[pos-offset]) len += 2;
            else return len;
            offset += 1;
        }
        return len;
    }
}
