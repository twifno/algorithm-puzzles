//https://leetcode.com/problems/meeting-rooms/

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
    public bool CanAttendMeetings(Interval[] intervals) {
        Array.Sort(intervals, (x, y) => x.end.CompareTo(y.end));
        for(int i = 0; i < intervals.Length-1; i++){
            if(intervals[i].end > intervals[i+1].start) return false;
        }
        return true;
    }
}
