//https://leetcode.com/problems/bomb-enemy/

//DP in 4 directions.

public class Solution {
    public int MaxKilledEnemies(char[,] grid) {
        int l0 = grid.GetLength(0);
        int l1 = grid.GetLength(1);
        int[,] up = new int[l0, l1];
        int[,] down = new int[l0, l1];
        int[,] left = new int[l0, l1];
        int[,] right = new int[l0, l1];
        for(int i = 0; i < l0; i++){
            for(int j = 0; j < l1; j++){
                char val = grid[i, j];
                if(val == 'W') {
                    up[i, j] = 0;
                    left[i, j] = 0;
                } else {
                    int sum = 0; 
                    if(i > 0) sum += up[i-1, j];
                    if(val == 'E') sum += 1;
                    up[i, j] = sum;
                    sum = 0;
                    if(j > 0) sum += left[i, j-1];
                    if(val == 'E') sum += 1;
                    left[i, j] = sum;
                }
            }
        }
        for(int i = l0-1; i >= 0; i--){
            for(int j = l1-1; j >= 0; j--){
                char val = grid[i, j];
                if(val == 'W') {
                    down[i, j] = 0;
                    right[i, j] = 0;
                } else {
                    int sum = 0; 
                    if(i < l0-1) sum += down[i+1, j];
                    if(val == 'E') sum += 1;
                    down[i, j] = sum;
                    sum = 0;
                    if(j < l1-1) sum += right[i, j+1];
                    if(val == 'E') sum += 1;
                    right[i, j] = sum;
                }
            }
        }
        int max = 0;
        for(int i = 0; i < l0; i++){
            for(int j = 0; j < l1; j++){
                if(grid[i, j] != '0') continue;
                max = Math.Max(max, up[i,j] + down[i,j] + left[i,j] + right[i,j]);
            }
        }
        return max;
    }
}
