//https://leetcode.com/problems/valid-tic-tac-toe-state/

public class Solution {
    public bool ValidTicTacToe(string[] board) {
        int xCount = Count('X', board);
        int oCount = Count('O', board);
        if(xCount > oCount + 1) return false;
        if(oCount > xCount) return false;
        bool xWin = IsWin('X', board);
        bool oWin = IsWin('O', board);
        if(xWin & oWin) return false;
        if(xCount == oCount && xWin) return false;
        if(xCount == oCount+1 && oWin) return false;
        return true;
    }
    
    private int Count(char c, string[] board) {
        int count = 0;
        foreach(string r in board) foreach(char cell in r) if(c == cell) count += 1;
        return count;
    }
    private bool IsWin(char c, string[] board){
        for(int i = 0; i < 3; i++){
            if(board[i][0] == c && board[i][1] == c && board[i][2] == c) return true;
            if(board[0][i] == c && board[1][i] == c && board[2][i] == c) return true;
        }
        if(board[0][0] == c && board[1][1] == c && board[2][2] == c) return true;
        if(board[0][2] == c && board[1][1] == c && board[2][0] == c) return true;
        return false;
    }
}
