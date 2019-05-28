//https://leetcode.com/problems/max-increase-to-keep-city-skyline/

public class Solution {
    public int MaxIncreaseKeepingSkyline(int[][] grid) {
        if(grid.Length == 0 || grid[0].Length == 0) return 0;
        int[] left = new int[grid.Length];
        int[] top = new int[grid[0].Length];
        for(int i = 0; i < grid.Length; i++){
            for(int j = 0; j < grid[i].Length; j++){
                left[i] = Math.Max(left[i], grid[i][j]);
                top[j] = Math.Max(top[j], grid[i][j]);
            }
        }
        int sum = 0;
        for(int i = 0; i < grid.Length; i++){
            for(int j = 0; j < grid[i].Length; j++){
                sum += Math.Min(top[j], left[i]) - grid[i][j];
            }
        }
        return sum;
    }
}
