//https://leetcode.com/problems/longest-substring-with-at-most-two-distinct-characters/

//Two pointer window move.

public class Solution {
    public int LengthOfLongestSubstringTwoDistinct(string s) {
        int count = 0;
        int[] counts = new int[128];
        int max = 0;
        int left = 0;
        int right = 0;
        while(right < s.Length){
            int index = s[right]-'A';
            if(counts[index] == 0) count+= 1;
            counts[index] += 1;
            while(count > 2) {
                int index2 = s[left] - 'A';
                counts[index2] -= 1;
                if(counts[index2] == 0) count -= 1;
                left += 1;
            }
            max = Math.Max(max, right - left + 1);
            right += 1;
        }
        return max;
    }
}
