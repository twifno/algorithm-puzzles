//https://leetcode.com/problems/number-of-corner-rectangles/

public class Solution {
    public int CountCornerRectangles(int[,] grid) {
        int l0 = grid.GetLength(0);
        int l1 = grid.GetLength(1);
        int sum = 0;
        for(int i = 0; i < l0-1; i++){
            for(int j = i+1; j < l0; j++){
                int count = 0;
                for(int k = 0; k < l1; k++){
                    if(grid[i,k] == 1 && grid[j,k] == 1) count += 1;
                }
                sum += (count-1)*count/2;
            }
        }
        return sum;
    }
}
