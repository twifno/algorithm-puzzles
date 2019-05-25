//https://leetcode.com/problems/valid-anagram/

//Just count the number

public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] counts = new int[26];
        if(s.Length != t.Length) return false;
        foreach(char c in s){
            counts[c-'a'] += 1;
        }
        foreach(char c in t){
            counts[c-'a'] -= 1;
        }
        foreach(int count in counts) if(count < 0) return false;
        return true;
    }
}
