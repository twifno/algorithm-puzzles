//https://leetcode.com/problems/line-reflection/

public class Solution {
    public bool IsReflected(int[,] points) {
        HashSet<string> hs = new HashSet<string>();
        int left = Int32.MaxValue;
        int right = Int32.MinValue;
        for(int i = 0; i < points.GetLength(0); i++){
            string key = points[i, 0] + ":" + points[i, 1];
            hs.Add(key);
            left = Math.Min(left, points[i, 0]);
            right = Math.Max(right, points[i, 0]);
        }
        int half2 = right + left;
        double half = half2*1.0/2;
        for(int i = 0; i < points.GetLength(0); i++){
            int x = points[i, 0];
            int y = points[i, 1];
            int antix = 0;
            if(x != half) {
                antix = half2 - x;
            } else {
                antix = x;
            }
            string key = antix + ":" + y;
            if(!hs.Contains(key)) return false;
        }
        return true;
    }
}
