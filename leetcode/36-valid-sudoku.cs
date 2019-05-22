//https://leetcode.com/problems/valid-sudoku/

//Check one by one

public class Solution {
    public bool IsValidSudoku(char[,] board) {
        for(int r = 0; r < 9; r++){
            bool[] flags = new bool[9];
            for(int c = 0; c < 9; c++){
                if(board[r,c] != '.'){
                    if(flags[board[r,c] - '1']) return false;
                    else flags[board[r,c] - '1'] = true;
                }
            }
        }
        for(int c = 0; c < 9; c++){
            bool[] flags = new bool[9];
            for(int r = 0; r < 9; r++){
                if(board[r,c] != '.'){
                    if(flags[board[r,c] - '1']) return false;
                    else flags[board[r,c] - '1'] = true;
                }
            }
        }
        for(int g1 = 0; g1 < 3; g1++){
            for(int g2 = 0; g2 < 3; g2++){
                bool[] flags = new bool[9];
                for(int r = g1*3; r < g1*3+3; r++){
                    for(int c = g2*3; c < g2*3+3; c++){
                        if(board[r,c] != '.'){
                            if(flags[board[r,c] - '1']) return false;
                            else flags[board[r,c] - '1'] = true;
                        }
                    }
                }
            }
        }
        return true;
    }
}
