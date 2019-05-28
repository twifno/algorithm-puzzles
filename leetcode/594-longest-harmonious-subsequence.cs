//https://leetcode.com/problems/longest-harmonious-subsequence/

public class Solution {
    public int FindLHS(int[] nums) {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        foreach(int n in nums){
            if(!counts.ContainsKey(n)) counts[n] = 1;
            else counts[n] += 1;
        }
        int max = 0;
        foreach(int n in counts.Keys){
            if(counts.ContainsKey(n+1)) max = Math.Max(max, counts[n] + counts[n+1]);
        }
        return max;
    }
}
