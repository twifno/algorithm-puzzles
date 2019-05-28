//https://leetcode.com/problems/reverse-string-ii/

public class Solution {
    public string ReverseStr(string s, int k) {
        char[] cs = s.ToCharArray();
        int pos = 0;
        while(pos < s.Length) {
            Array.Reverse(cs, pos, Math.Min(k, s.Length-pos));
            pos += 2*k;
        }
        return new string(cs);
    }
}
