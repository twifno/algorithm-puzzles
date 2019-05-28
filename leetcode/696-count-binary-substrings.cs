//https://leetcode.com/problems/count-binary-substrings/

public class Solution {
    public int CountBinarySubstrings(string s) {
        if(s.Length == 0) return 0;
        int count = 1;
        char cur = s[0];
        List<int> counts = new List<int>();
        for(int i = 1; i < s.Length; i++){
            if(s[i] == cur) count += 1;
            else {
                counts.Add(count);
                count = 1;
                cur = s[i];
            }
        }
        counts.Add(count);
        int sum = 0;
        for(int i = 0; i < counts.Count - 1; i++){
            sum += Math.Min(counts[i], counts[i+1]);
        }
        return sum;
    }
}
