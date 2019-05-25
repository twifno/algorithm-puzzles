//https://leetcode.com/problems/walls-and-gates/

public class Solution {
    public void WallsAndGates(int[][] rooms) {
        int l0 = rooms.Length;
        if(l0 == 0) return;
        int l1 = rooms[0].Length;
        if(l1 == 0) return;
        Queue<Point> q = new Queue<Point>();
        for(int i = 0; i < l0; i++){
            for(int j = 0; j < l1; j++){
                if(rooms[i][j] == 0) q.Enqueue(new Point(i, j));
            }
        }
        Bfs(q, rooms);
    }
    
    class Point {
        public int X;
        public int Y;
        public Point(int x, int y) {
            X = x;
            Y = y;
        }
    }
    
    private void Bfs(Queue<Point> q, int[][] rooms) {
        int l0 = rooms.Length;
        int l1 = rooms[0].Length;
        int[,] dir = {{0,1}, {0,-1}, {1,0}, {-1,0}};
        bool[,] visited = new bool[l0, l1];
        while(q.Count > 0) {
            Point p = q.Dequeue();
            for(int k = 0; k < 4; k++){
                int ni = p.X + dir[k, 0];
                int nj = p.Y + dir[k, 1];
                if(ni < 0 || ni >= l0) continue;
                if(nj < 0 || nj >= l1) continue;
                if(!visited[ni, nj] && rooms[ni][nj] > 0) {
                    visited[ni, nj] = true;
                    rooms[ni][nj] = rooms[p.X][p.Y] + 1;
                    q.Enqueue(new Point(ni, nj));
                }
            }
        }
    }
}
