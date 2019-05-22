//https://leetcode.com/problems/merge-intervals/

//Sort by the end before merge.

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
    public IList<Interval> Merge(IList<Interval> intervals) {
        List<Interval> res = new List<Interval>(intervals);
        if(intervals.Count <= 1) return intervals;
        res.Sort((x, y) => x.end.CompareTo(y.end));
        for(int i = res.Count-2; i >= 0; i--){
            if(res[i].end >= res[i+1].start) {
                res[i].end = res[i+1].end;
                res[i].start = Math.Min(res[i].start, res[i+1].start);
                res.RemoveAt(i+1);
            }
        }
        return res;
    }
}
