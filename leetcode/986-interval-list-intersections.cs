//https://leetcode.com/problems/interval-list-intersections/

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
    public Interval[] IntervalIntersection(Interval[] A, Interval[] B) {
        List<Interval> res = new List<Interval>();
        int curA = 0; int curB = 0;
        while(curA < A.Length && curB < B.Length){
            int start = Math.Max(A[curA].start, B[curB].start);
            int end = Math.Min(A[curA].end, B[curB].end);
            if(start <= end) {
                res.Add(new Interval(start, end));
            }
            if(B[curB].end >= A[curA].end) {
                curA += 1;
            } else {
                curB += 1;
            }
        }
        return res.ToArray();
    }
}
