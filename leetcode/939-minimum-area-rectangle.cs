//https://leetcode.com/problems/minimum-area-rectangle/

public class Solution {
    public int MinAreaRect(int[][] points) {
        if(points.Length == 0) return 0;
        Dictionary<string, int> rows = new Dictionary<string, int>();
        Array.Sort(points, (x, y) => x[0]==y[0]?x[1].CompareTo(y[1]):x[0].CompareTo(y[0]));
        int cur = 0;
        int min = Int32.MaxValue;
        while(cur < points.Length) {
            int head = cur;
            int tail = cur;
            while(tail < points.Length-1 && points[tail+1][0] == points[tail][0]) tail+=1;
            for(int i = head; i <= tail-1; i++){
                for(int j = i+1; j <= tail; j++){
                    string row = points[i][1] + ":" + points[j][1];
                    if(rows.ContainsKey(row)) {
                        min = Math.Min(min, (points[i][0] - rows[row]) * (points[j][1] - points[i][1]));
                    }
                    rows[row] = points[i][0];
                }
            }
            cur = tail+1;
        }
        if(min == Int32.MaxValue) min=0;
        return min;
    }
}
