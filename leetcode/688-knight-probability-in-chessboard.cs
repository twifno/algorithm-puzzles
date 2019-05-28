//https://leetcode.com/problems/knight-probability-in-chessboard/

public class Solution {
    public double KnightProbability(int N, int K, int r, int c) {
        double[,] board = new double[N, N];
        board[r, c] = 1;
        int[,] dir = {{-1, -2}, {-2, -1}, {-2, 1}, {-1, 2}, {1, -2}, {2, -1}, {1, 2}, {2, 1}};
        for(int t = 0; t < K; t++){
            double[,] newBoard = new double[N, N];
            for(int i = 0; i < N; i++){
                for(int j = 0; j < N; j++){
                    if(board[i, j] == 0) continue;
                    for(int d = 0; d < dir.GetLength(0); d++){
                        int x = i+dir[d,0];
                        int y = j+dir[d,1];
                        if(x < 0 || y < 0) continue;
                        if(x >= N || y >= N) continue;
                        newBoard[x, y] += board[i, j]/8;
                    }
                }
            }
            board = newBoard;
        }
        double sum = 0;
        for(int i = 0; i < N; i++){
            for(int j = 0; j < N; j++){
                sum += board[i, j];
            }
        }
        return sum;
    }
}
