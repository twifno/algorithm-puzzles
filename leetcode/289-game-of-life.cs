//https://leetcode.com/problems/game-of-life/

//Use the higher bit of the board to remember the next stage

public class Solution {
    public void GameOfLife(int[][] board) {
        int l0 = board.Length;
        if(l0 == 0) return;
        int l1 = board[0].Length;
        for(int i = 0; i < l0; i++){
            for(int j = 0; j < l1; j++){
                Next(i, j, board);
            }
        }
        for(int i = 0; i < l0; i++){
            for(int j = 0; j < l1; j++){
                if((board[i][j] & 2) == 2) board[i][j] = 1;
                else board[i][j] = 0;
            }
        }
    }
    
    private void Next(int r, int c, int[][] board){
        int count = 0;
        for(int i = -1; i <= 1; i++){
            for(int j = -1; j <= 1; j++){
                if(i == 0 && j == 0) continue;
                if(r+i < 0 || r+i > board.Length-1) continue;
                if(c+j < 0 || c+j > board[0].Length-1) continue;
                if((board[r+i][c+j] & 1) == 1) count += 1;
            }
        }
        if((board[r][c] & 1) == 1) {
            if(count >= 2 && count <= 3) board[r][c] |= 2;
        } else {
            if(count == 3) board[r][c] |= 2;
        }
    }
}
