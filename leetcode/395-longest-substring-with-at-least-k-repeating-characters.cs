//https://leetcode.com/problems/longest-substring-with-at-least-k-repeating-characters/

public class Solution {
    public int LongestSubstring(string s, int k) {
        if(s.Length == 0) return 0;
        int[] counts = new int[26];
        foreach(char c in s){
            counts[c-'a'] += 1;
        }
        bool atleastk = true;
        for(int i = 0; i < 26; i++){
            if(counts[i] > 0 && counts[i] < k) {
                atleastk = false;
                break;
            }
        }
        if(atleastk) return s.Length;
        int max = 0;
        int start = -1;
        int cur = 0;
        while(cur < s.Length){
            int count = counts[s[cur] - 'a'];
            if(count > 0 && count < k) {
                max = Math.Max(max, LongestSubstring(s.Substring(start+1, cur-start-1), k));
                start = cur;
            }
            cur += 1;
        }
        max = Math.Max(max, LongestSubstring(s.Substring(start+1, cur-start-1), k));
        return max;
    }
}
