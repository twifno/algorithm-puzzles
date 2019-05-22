//https://leetcode.com/problems/sudoku-solver/

//DFS search…

public class Solution {
    public void SolveSudoku(char[][] board) {
        bool[,,] taken = new bool[9,9,10];
        for(int r = 0; r < 9; r++){
            for(int c = 0; c < 9; c++){
                if(board[r][c] != '.'){
                    int val = board[r][c] - '0';
                    for(int row = 0; row < 9; row++){
                        taken[row,c,val] = true;
                    }
                    for(int col = 0; col < 9; col++){
                        taken[r,col,val] = true;
                    }
                    int g1 = r/3;
                    int g2 = c/3;
                    for(int row = g1*3; row < g1*3+3; row++){
                        for(int col = g2*3; col < g2*3+3; col++){
                            taken[row,col,val] = true;
                        }
                    }
                }
            }
        }
        Fill(0, 0, board, taken);
    }
    private bool Check(int r, int c, char[][] board, char val){
        for(int row = 0; row < 9; row++){
            if(board[row][c] == val) return false;
        }
        for(int col = 0; col < 9; col++){
            if(board[r][col] == val) return false;
        }
        int g1 = r/3;
        int g2 = c/3;
        for(int row = g1*3; row < g1*3+3; row++){
            for(int col = g2*3; col < g2*3+3; col++){
                if(board[row][col] == val) return false;
            }
        }
        return true;
    }
    
    private bool Fill(int r, int c, char[][] board, bool[,,] taken){
        if(r == 9) return true;
        if(board[r][c] != '.') return Fill(r+(c+1)/9, (c+1)%9, board, taken);
        for(int i = 1; i <= 9; i++){
            if(taken[r,c,i]) {
                continue;
            }
            char cha = (char)('0'+i);
            if(!Check(r, c, board, cha)) continue;
            board[r][c] = cha;
            if(Fill(r+(c+1)/9, (c+1)/9, board, taken)) return true;
            board[r][c] = '.';
        }
        return false;
    }
}
