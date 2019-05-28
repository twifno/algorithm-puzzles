//https://leetcode.com/problems/the-maze/

//BFS

public class Solution {
    class Point {
        public int X;
        public int Y;
        public Point(int x, int y){
            X = x;
            Y = y;
        }
    }
    
    public bool HasPath(int[][] maze, int[] start, int[] destination) {
        int l0 = maze.Length;
        int l1 = maze[0].Length;
        Point init = new Point(start[0], start[1]);
        Queue<Point> q = new Queue<Point>();
        q.Enqueue(init);
        bool[,] visited = new bool[l0, l1];
        visited[init.X, init.Y] = true;
        while(q.Count > 0) {
            Point p = q.Dequeue();
            if((p.X == destination[0]) && (p.Y == destination[1])) return true;
            Point left = Left(p, maze);
            if(!visited[left.X, left.Y]) {
                visited[left.X, left.Y] = true;
                q.Enqueue(left);
            }
            Point right = Right(p, maze);
            if(!visited[right.X, right.Y]) {
                visited[right.X, right.Y] = true;
                q.Enqueue(right);
            }
            Point up = Up(p, maze);
            if(!visited[up.X, up.Y]) {
                visited[up.X, up.Y] = true;
                q.Enqueue(up);
            }
            Point down = Down(p, maze);
            if(!visited[down.X, down.Y]) {
                visited[down.X, down.Y] = true;
                q.Enqueue(down);
            }
        }
        return false;
    }
    
    private Point Left(Point p, int[][] maze) {
        Point left = new Point(p.X, p.Y);
        while(left.X > 0 && maze[left.X-1][left.Y] == 0) left.X -= 1;
        return left;
    }
    private Point Right(Point p, int[][] maze) {
        Point right = new Point(p.X, p.Y);
        while(right.X < maze.Length-1 && maze[right.X+1][right.Y] == 0) right.X += 1;
        return right;
    }
    private Point Up(Point p, int[][] maze) {
        Point up = new Point(p.X, p.Y);
        while(up.Y > 0 && maze[up.X][up.Y-1] == 0) up.Y -= 1;
        return up;
    }
    private Point Down(Point p, int[][] maze) {
        Point down = new Point(p.X, p.Y);
        while(down.Y < maze[0].Length-1 && maze[down.X][down.Y+1] == 0) down.Y += 1;
        return down;
    }
}
