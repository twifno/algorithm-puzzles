//https://leetcode.com/problems/first-unique-character-in-a-string/

public class Solution {
    public int FirstUniqChar(string s) {
        int[] counts = new int[26];
        foreach(char c in s){
            counts[c-'a'] += 1;
        }
        for(int i = 0; i < s.Length; i++){
            if(counts[s[i] - 'a'] == 1) return i;
        }
        return -1;
    }
}
