//https://leetcode.com/problems/length-of-last-word/

public class Solution {
    public int LengthOfLastWord(string s) {
        s = s.TrimEnd(new char[] {' '});
        if(s.Length == 0) return 0;
        int cur = s.Length-1;
        while(cur >= 0 && s[cur] != ' ') cur -= 1;
        if(cur == -1) return s.Length;
        else return s.Length-cur-1;
    }
}
