//https://leetcode.com/problems/insert-interval/

//Insert and merge.

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
    public IList<Interval> Insert(IList<Interval> intervals, Interval newInterval) {
        List<Interval> res = new List<Interval>(intervals);
        res.Add(newInterval);
        Merge(res);
        return res;
    }
    
    public IList<Interval> Merge(List<Interval> res) {
        if(res.Count <= 1) return res;
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

