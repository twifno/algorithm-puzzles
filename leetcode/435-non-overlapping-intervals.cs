//https://leetcode.com/problems/non-overlapping-intervals/

/**
 * Definition for an interval.
 * public class Interval {
 *     public int start;
 *     public int end;
 *     public Interval() { start = 0; end = 0; }
 *     public Interval(int s, int e) { start = s; end = e; }
 * }
 */
public class Solution {
    public int EraseOverlapIntervals(Interval[] intervals) {
        if(intervals.Length <= 1) return 0;
        Array.Sort(intervals, (x, y) => x.end.CompareTo(y.end));
        int end = intervals[0].end;
        int count = 0;
        for(int i = 1; i < intervals.Length; i++){
            if(intervals[i].start < end) count += 1;
            else end = intervals[i].end;
        }
        return count;
    }
}
