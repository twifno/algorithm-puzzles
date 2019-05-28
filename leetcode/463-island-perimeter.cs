//https://leetcode.com/problems/island-perimeter/

public class Solution {
    public int IslandPerimeter(int[,] grid) {
        int count = 0;
        int l0 = grid.GetLength(0);
        int l1 = grid.GetLength(1);
        for(int i = 0; i < l0; i++){
            for(int j = 0; j < l1; j++){
                if(grid[i, j] == 1){
                    if(i <= 0 || grid[i-1, j] == 0) count += 1;
                    if(j <= 0 || grid[i, j-1] == 0) count += 1;
                    if(i >= l0-1 || grid[i+1, j] == 0) count += 1;
                    if(j >= l1-1 || grid[i, j+1] == 0) count += 1;
                }
            }
        }
        return count;
    }
}
