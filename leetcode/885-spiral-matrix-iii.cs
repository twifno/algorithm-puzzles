//https://leetcode.com/problems/spiral-matrix-iii/

public class Solution {
    public int[][] SpiralMatrixIII(int R, int C, int r0, int c0) {
        int[,] dir = {{0, 1}, {1, 0}, {0, -1}, {-1, 0}};
        int dirCount = 0;
        int step = 1;
        int count = 0;
        int[][] res = new int[R*C][];
        res[count++] = new int[2]{r0, c0};
        int x = r0;
        int y = c0;
        while(count < R*C) {
            int d = dirCount % 4;
            for(int i = 0; i < step; i++){
                x += dir[d, 0];
                y += dir[d, 1];
                if(x >= 0 && x < R && y >= 0 && y < C) {
                    res[count++] = new int[2]{x, y};
                }
                if(count == R*C) return res;
            }
            dirCount += 1;
            if(dirCount % 2 == 0) step += 1;
        }
        return res;
    }
}
