//https://leetcode.com/problems/minimum-number-of-arrows-to-burst-balloons/

//Greedy on the end time

public class Solution {
    class Interval {
        public int Start;
        public int End;
        public bool Shot;
        public Interval(int start, int end){
            Start = start;
            End = end;
        }
    }
    
    public int FindMinArrowShots(int[,] points) {
        int len  = points.GetLength(0);
        Interval[] intervalsStart = new Interval[len];
        for(int i = 0; i < len; i++) intervalsStart[i] = new Interval(points[i, 0], points[i, 1]);
        Interval[] intervalsEnd = (Interval[])intervalsStart.Clone();
        Array.Sort(intervalsStart, (x, y) => x.Start.CompareTo(y.Start));
        Array.Sort(intervalsEnd, (x, y) => x.End.CompareTo(y.End));
        int count = 0;
        int cur = 0;
        for(int i = 0; i < len; i++){
            if(!intervalsEnd[i].Shot){
                count += 1;
                int end = intervalsEnd[i].End;
                while(cur < len && intervalsStart[cur].Start <= end){
                    intervalsStart[cur].Shot = true;
                    cur += 1;
                }
            }
        }
        return count;
    }
}
