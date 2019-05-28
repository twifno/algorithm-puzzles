//https://leetcode.com/problems/most-stones-removed-with-same-row-or-column/

public class Solution {
    class Point {
        public int X;
        public int Y;
        public Point(int x, int y){
            X = x;
            Y = y;
        }
    }
    
    public int RemoveStones(int[][] stones) {
        int len = stones.Length;
        Point[] pts = new Point[len];
        Dictionary<Point, Point> parents = new Dictionary<Point, Point>();
        for(int i = 0; i < len; i++) {
            Point p = new Point(stones[i][0], stones[i][1]);
            parents[p] = p;
            pts[i] = p;
        }
        Array.Sort(pts, (a, b) => (a.X.CompareTo(b.X)));
        for(int i = 1; i < len; i++){
            if(pts[i-1].X == pts[i].X) {
                Point p1 = Find(pts[i-1], parents);
                Point p2 = Find(pts[i], parents);
                if(p1 != p2) parents[p1] = p2;
            }
        }
        Array.Sort(pts, (a, b) => (a.Y.CompareTo(b.Y)));
        for(int i = 1; i < len; i++){
            if(pts[i-1].Y == pts[i].Y) {
                Point p1 = Find(pts[i-1], parents);
                Point p2 = Find(pts[i], parents);
                if(p1 != p2) parents[p1] = p2;
            }
        }
        List<Point> keys = new List<Point>(parents.Keys);
        Dictionary<Point, int> counts = new Dictionary<Point, int>();
        foreach(Point p in keys) {
            Point parent = Find(p, parents);
            if(counts.ContainsKey(parent)) counts[parent] += 1;
            else counts[parent] = 1;
        }
        int count = 0;
        foreach(int c in counts.Values){
            count += c-1;
        }
        return count;
    }
    
    private Point Find(Point p, Dictionary<Point, Point> parents) {
        while(p != parents[p]){
            parents[p] = parents[parents[p]];
            p = parents[p];
        }
        return p;
    }
}
