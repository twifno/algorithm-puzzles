//https://leetcode.com/problems/number-of-distinct-islands/

public class Solution {
    public int NumDistinctIslands(int[,] grid) {
        int l0 = grid.GetLength(0);
        int l1 = grid.GetLength(1);
        bool[,] visited = new bool[l0, l1];
        HashSet<string> pathes = new HashSet<string>();
        for(int i = 0; i < l0; i++){
            for(int j = 0; j < l1; j++){
                if(grid[i, j] == 1 && !visited[i, j]) pathes.Add(Path(i, j, grid, visited));
            }
        }
        return pathes.Count;    
    }

    class Cell {
        public int R;
        public int C;
        public Cell(int r, int c) {
            R = r;
            C = c;
        }
    }
    
    private string Path(int r, int c, int[,] grid, bool[,] visited){
        int l0 = grid.GetLength(0);
        int l1 = grid.GetLength(1);
        Stack<Cell> st = new Stack<Cell>();
        visited[r, c] = true;
        Cell prev = new Cell(r, c);
        List<string> path = new List<string>();
        st.Push(prev);
        while(st.Count > 0){
            Cell cell = st.Pop();
            int row = cell.R;
            int col = cell.C;
            path.Add((row-prev.R)+":"+(col-prev.C));
            prev = cell;
            if(row > 0 && grid[row-1, col] == 1 && !visited[row-1, col]) { st.Push(new Cell(row-1, col)); visited[row-1, col] = true; }
            if(col > 0 && grid[row, col-1] == 1 && !visited[row, col-1]) { st.Push(new Cell(row, col-1)); visited[row, col-1] = true; }
            if(row < l0-1 && grid[row+1, col] == 1 && !visited[row+1, col]) { st.Push(new Cell(row+1, col)); visited[row+1, col] = true; }
            if(col < l1-1 && grid[row, col+1] == 1 && !visited[row, col+1]) { st.Push(new Cell(row, col+1)); visited[row, col+1] = true; }
        }
        string pathStr = string.Join(",", path);
        //System.Console.WriteLine(pathStr);
        return pathStr;
    }
}
