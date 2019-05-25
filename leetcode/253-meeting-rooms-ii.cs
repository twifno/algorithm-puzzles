//https://leetcode.com/problems/meeting-rooms-ii/

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
    public int MinMeetingRooms(Interval[] intervals) {
        int len = intervals.Length;
        int[] inTime = new int[len];
        int[] outTime = new int[len];
        for(int i = 0; i < len; i++){
            inTime[i] = intervals[i].start;
            outTime[i] = intervals[i].end;
        }
        Array.Sort(inTime);
        Array.Sort(outTime);
        int pos1 = 0;
        int pos2 = 0;
        int count = 0;
        int max = 0;
        while(pos1 < len){
            if(inTime[pos1] < outTime[pos2]) {
                pos1 += 1;
                count += 1;
                max = Math.Max(max, count);
            } else {
                pos2 += 1;
                count -= 1;
            }
        }
        return max;
    }
}
