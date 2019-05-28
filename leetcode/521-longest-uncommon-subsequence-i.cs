//https://leetcode.com/problems/longest-uncommon-subsequence-i/

public class Solution {
    public int FindLUSlength(string a, string b) {
        if(a != b) return Math.Max(a.Length, b.Length);
        else return -1;
    }
}
