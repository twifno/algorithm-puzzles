//https://leetcode.com/problems/longest-consecutive-sequence/

public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> hs = new HashSet<int>();
        foreach(int n in nums) hs.Add(n);
        HashSet<int> visited = new HashSet<int>();
        int maxCount = 0;
        foreach(int n in hs){
            //if(visited.Contains(n)) continue;
            //visited.Add(n);
            int end = n+1;
            while(hs.Contains(end)){
                //visited.Add(end);
                end += 1;
            }
            maxCount = Math.Max(maxCount, end-n);
        }
        return maxCount;
    }
}
