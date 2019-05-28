//https://leetcode.com/problems/minimum-time-difference/

public class Solution {
    public int FindMinDifference(IList<string> timePoints) {
        int len = timePoints.Count;
        int[] minus = new int[len];
        for(int i = 0; i < len; i++){
            string[] ts = timePoints[i].Split(":");
            minus[i] = Int32.Parse(ts[0]) * 60 + Int32.Parse(ts[1]);
        }
        Array.Sort(minus);
        int min = Int32.MaxValue;
        for(int i = 1; i < len; i++){
            min = Math.Min(min, minus[i] - minus[i-1]);
        }
        min = Math.Min(min, minus[0] + 24*60 - minus[len-1]);
        return min;
    }
}
