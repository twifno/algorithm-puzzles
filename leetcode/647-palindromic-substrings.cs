//https://leetcode.com/problems/palindromic-substrings/

//Treat even odd differently.

public class Solution {
    public int CountSubstrings(string s) {
        int count = 0;
        for(int i = 0; i < s.Length; i++) {
            count += GetPalOdd(s, i);
            count += GetPalEven(s, i);
        }
        return count;
    }
    
    private int GetPalOdd(string s, int pos){
        int len = 0;
        while(pos - len > 0 && pos + len < s.Length-1 && s[pos-len-1] == s[pos+len+1]) len += 1;
        return len + 1;
    }
    
    private int GetPalEven(string s, int pos){
        int len = 0;
        while(pos - len > 0 && pos + len - 1 < s.Length-1 && s[pos-len-1] == s[pos+len]) len += 1;
        return len;
    }
}
