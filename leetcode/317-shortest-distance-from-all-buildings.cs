//https://leetcode.com/problems/shortest-distance-from-all-buildings/

//BFS from each building

public class Solution {
    public int ShortestDistance(int[][] grid) {
        int l0 = grid.Length;
        int l1 = grid[0].Length;
        int[,] counts = new int[l0, l1];
        int[,] dists = new int[l0, l1];
        int count = 0;
        for(int i = 0; i < l0; i++) {
            for(int j = 0; j < l1; j++){
                if(grid[i][j] == 1) {
                    count += 1;
                    bool[,] visited = new bool[l0, l1];
                    Bfs(i, j, grid, visited, counts, dists);
                }
            }
        }
        int min = Int32.MaxValue;
        for(int i = 0; i < l0; i++) {
            for(int j = 0; j < l1; j++){
                if(grid[i][j] == 0 && counts[i, j] == count) min = Math.Min(min, dists[i, j]);
            }
        }
        if(min == Int32.MaxValue) return -1;
        return min;
    }
    
    int[,] Dir = {{0, 1}, {0, -1}, {1, 0}, {-1,0}};
    
    class Node {
        public int X;
        public int Y;
        public int Dist;
        public Node(int x, int y, int dist) {
            X = x;
            Y = y;
            Dist = dist;
        }
    }
    
    private void Bfs(int i, int j, int[][] grid, bool[,] visited, int[,] counts, int[,] dists){
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(new Node(i, j, 0));
        while(q.Count > 0) {
            Node n = q.Dequeue();
            for(int k = 0; k < Dir.GetLength(0); k++){
                int ni = n.X+Dir[k,0];
                int nj = n.Y+Dir[k,1];
                if(ni < 0 || ni >= grid.Length) continue;
                if(nj < 0 || nj >= grid[0].Length) continue;
                if(grid[ni][nj] == 0 && !visited[ni, nj]) {
                    visited[ni, nj] = true;
                    dists[ni, nj] += n.Dist+1;
                    counts[ni, nj] += 1;
                    q.Enqueue(new Node(ni, nj, n.Dist+1));
                }
            }
        }
    }
    
}
