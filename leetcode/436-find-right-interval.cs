//https://leetcode.com/problems/find-right-interval/

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
    class IntervalPlus: Interval {
        public int pos;
        public int right;
        public IntervalPlus(Interval inte, int p): base(inte.start, inte.end){
            pos = p;
            right = -1;
        }
    }
    
    public int[] FindRightInterval(Interval[] intervals) {
        IntervalPlus[] st = new IntervalPlus[intervals.Length];
        for(int i = 0; i < intervals.Length; i++){
            st[i] = new IntervalPlus(intervals[i], i);
        }
        IntervalPlus[] ed = (IntervalPlus[])st.Clone();
        Array.Sort(st, (x, y)=>x.start.CompareTo(y.start));
        Array.Sort(ed, (x, y)=>x.end.CompareTo(y.end));
        int p1 = 0; int p2 = 0;
        while(p1 < st.Length){
            if(st[p1].start >= ed[p2].end){
                ed[p2].right = st[p1].pos;
                if(p2 == ed.Length-1) break;
                p2 += 1;
            } else p1 += 1;
        }
        int[] res = new int[st.Length];
        foreach(IntervalPlus inte in ed){
            res[inte.pos] = inte.right;
        }
        return res;
    }
}
