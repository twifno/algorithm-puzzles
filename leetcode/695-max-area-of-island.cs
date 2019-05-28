//https://leetcode.com/problems/max-area-of-island/

public class Solution {
    public int MaxAreaOfIsland(int[,] grid) {
        int l0 = grid.GetLength(0);
        int l1 = grid.GetLength(1);
        bool[,] visited = new bool[l0, l1];
        int max  = 0;
        for(int i = 0; i < l0; i++){
            for(int j = 0; j < l1; j++){
                if(grid[i, j] == 1 && !visited[i, j]) max = Math.Max(max, Size(i, j, grid, visited));
            }
        }
        return max;
    }
    
    class Cell {
        public int R;
        public int C;
        public Cell(int r, int c) {
            R = r;
            C = c;
        }
    }
    
    private int Size(int r, int c, int[,] grid, bool[,] visited){
        int l0 = grid.GetLength(0);
        int l1 = grid.GetLength(1);
        int count = 1;
        Stack<Cell> st = new Stack<Cell>();
        visited[r, c] = true;
        st.Push(new Cell(r, c));
        while(st.Count > 0){
            Cell cell = st.Pop();
            int row = cell.R;
            int col = cell.C;
            if(row > 0 && grid[row-1, col] == 1 && !visited[row-1, col]) { st.Push(new Cell(row-1, col)); count += 1; visited[row-1, col] = true; }
            if(col > 0 && grid[row, col-1] == 1 && !visited[row, col-1]) { st.Push(new Cell(row, col-1)); count += 1; visited[row, col-1] = true; }
            if(row < l0-1 && grid[row+1, col] == 1 && !visited[row+1, col]) { st.Push(new Cell(row+1, col)); count += 1; visited[row+1, col] = true; }
            if(col < l1-1 && grid[row, col+1] == 1 && !visited[row, col+1]) { st.Push(new Cell(row, col+1)); count += 1; visited[row, col+1] = true; }
        }
        return count;
    }
}
