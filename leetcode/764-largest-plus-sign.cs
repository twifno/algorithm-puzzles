//https://leetcode.com/problems/largest-plus-sign/

public class Solution {
    class Cell {
        public int Up;
        public int Down;
        public int Left;
        public int Right;
        public int Val;
        public Cell(int v){
            Val = v;
        }
    }

    public int OrderOfLargestPlusSign(int N, int[,] mines) {
        Cell[,] Grid = new Cell[N,N];
        for(int i = 0; i < N; i++){
            for(int j = 0; j < N; j++){
                Grid[i, j] = new Cell(1);
            }
        }
        for(int i = 0; i < mines.GetLength(0); i++){
            Grid[mines[i, 0], mines[i, 1]].Val = 0;
        }
        for(int i = 0; i < N; i++){
            for(int j = 0; j < N; j++){
                Cell c = Grid[i, j];
                if(c.Val == 0) continue;
                if(i > 0){
                    c.Up = Grid[i-1, j].Up + 1;
                } else {
                    c.Up = 1;
                }
                if(j > 0){
                    c.Left = Grid[i, j-1].Left + 1;
                } else {
                    c.Left = 1;
                }
            }
        }
        int max = 0;
        for(int i = N-1; i >= 0; i--){
            for(int j = N-1; j >= 0; j--){
                Cell c = Grid[i, j];
                if(c.Val == 0) continue;
                if(i < N-1){
                    c.Down = Grid[i+1, j].Down + 1;
                } else {
                    c.Down = 1;
                }
                if(j < N-1){
                    c.Right = Grid[i, j+1].Right + 1;
                } else {
                    c.Right = 1;
                }
            
                int size = Math.Min(c.Up, c.Down);
                size = Math.Min(size, c.Left);
                size = Math.Min(size, c.Right);
                max = Math.Max(size, max);
            }
        }
        return max;
    }   
}
