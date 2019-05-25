//https://leetcode.com/problems/ransom-note/

public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int[] counts = new int[26];
        foreach(char c in magazine){
            counts[c-'a'] += 1;
        }
        foreach(char c in ransomNote){
            int offset = c - 'a';
            if(counts[offset] <= 0) return false;
            else counts[offset] -= 1;
        }
        return true;
    }
}
