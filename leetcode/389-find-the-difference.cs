//https://leetcode.com/problems/find-the-difference/

public class Solution {
    public char FindTheDifference(string s, string t) {
        int[] counts = new int[26]; 
        foreach(char c in s) counts[c-'a'] += 1;
        foreach(char c in t) counts[c-'a'] -= 1;
        for(int i = 0; i < 26; i++) if(counts[i] == -1) return (char)((int)'a' + i);
        return 'a';
    }
}
