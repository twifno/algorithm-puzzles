//https://leetcode.com/problems/number-of-islands/

public class Solution {
    public int NumIslands(char[,] grid) {
        int count = 0;
        for(int i = 0; i < grid.GetLength(0); i++){
            for(int j = 0; j < grid.GetLength(1); j++){
                if(grid[i, j] == '1'){
                    count += 1;
                    Visit(i, j, grid);
                }
            }
        }
        return count;
    }
    
    private void Visit(int r, int c, char[,] grid){
        grid[r, c] = '0';
        if(r > 0 && grid[r-1, c] == '1') Visit(r-1, c, grid);
        if(c > 0 && grid[r, c-1] == '1') Visit(r, c-1, grid);
        if(r < grid.GetLength(0)-1 && grid[r+1, c] == '1') Visit(r+1, c, grid);
        if(c < grid.GetLength(1)-1 && grid[r, c+1] == '1') Visit(r, c+1, grid);
    }
}
