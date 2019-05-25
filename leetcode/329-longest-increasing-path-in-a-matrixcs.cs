//https://leetcode.com/problems/longest-increasing-path-in-a-matrix/

public class Solution {
    public int LongestIncreasingPath(int[][] matrix) {
        int l0 = matrix.Length;
        if(l0 == 0) return 0;
        int l1 = matrix[0].Length;
        if(l1 == 0) return 0;
        int[,] counts = new int[l0, l1];
        int max = 0;
        for(int i = 0; i < l0; i++){
            for(int j = 0; j < l1; j++){
                if(counts[i, j] == 0) {
                    Dfs(i, j, matrix, counts);
                    max = Math.Max(max, counts[i, j]);
                }
                //System.Console.WriteLine(counts[i, j]);
            }
        }
        return max;
    }
    
    private void Dfs(int x, int y, int[][] matrix, int[,] counts){
        int l0 = matrix.Length;
        int l1 = matrix[0].Length;
        int max = 0;
        for(int i = -1; i <= 1; i++){
            for(int j = -1; j <= 1; j++){
                if(i == 0 && j == 0) continue;
                if(i+x < 0 || i+x >= l0) continue;
                if(j+y < 0 || j+y >= l1) continue;
                if(i + j == 0 || i+j == 2 || i+j == -2) continue;
                if(matrix[x][y] <= matrix[i+x][j+y]) continue;
                if(counts[i+x, j+y] == 0) Dfs(i+x, j+y, matrix, counts);
                max = Math.Max(counts[i+x, j+y], max);
            }
        }
        counts[x, y] = max+1;
    }
}
