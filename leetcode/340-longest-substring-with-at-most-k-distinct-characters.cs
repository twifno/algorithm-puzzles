//https://leetcode.com/problems/longest-substring-with-at-most-k-distinct-characters/

public class Solution {
    public int LengthOfLongestSubstringKDistinct(string s, int k) {
        int head = 0;
        int tail = 0;
        int max = 0;
        Dictionary<char, int> counts = new Dictionary<char, int>();
        while(tail < s.Length) {
            while(tail < s.Length && counts.Keys.Count <= k) {
                if(counts.ContainsKey(s[tail])) counts[s[tail]] += 1;
                else {
                   counts[s[tail]] = 1; 
                }
                tail += 1;
                if(counts.Keys.Count <= k) max = Math.Max(tail-head, max);
            }
            while(counts.Keys.Count > k) {
                counts[s[head]] -= 1;
                if(counts[s[head]] == 0) counts.Remove(s[head]);
                head += 1;
            }
        }
        return max;
    }
}
