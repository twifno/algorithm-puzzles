//https://leetcode.com/problems/valid-parenthesis-string/

public class Solution {
    public bool CheckValidString(string s) {
        int hi = 0;
        int lo = 0;
        foreach(char c in s){
            if(c == '(') { hi += 1; lo += 1; }
            else if(c == ')') { hi -= 1; lo = Math.Max(lo-1, 0); if(hi < 0) return false; }
            else { hi += 1; lo = Math.Max(lo-1, 0); }
        }
        return lo == 0;
    }
}
