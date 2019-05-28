//https://leetcode.com/problems/permutation-in-string/

public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int[] counts = new int[26];
        int sum = 0;
        foreach(char c in s1){
            sum += 1;
            counts[c-'a'] += 1;
        }
        if(s1.Length > s2.Length) return false;
        int right = 0;
        int left = 0;
        while(right < s2.Length){
            int c = s2[right] - 'a';
            counts[c] -= 1;
            if(counts[c] >= 0) sum -= 1;
            else sum += 1;
            if(right - left + 1 > s1.Length){
                int cc = s2[left] - 'a';
                counts[cc] += 1;
                if(counts[cc] <= 0) sum -= 1;
                else sum += 1;
                left += 1;
            }
            if(sum == 0) return true;
            right += 1;
        }
        return false;
    }
}
