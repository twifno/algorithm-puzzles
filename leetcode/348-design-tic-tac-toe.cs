//https://leetcode.com/problems/design-tic-tac-toe/

//O(1) 

public class TicTacToe {
    int[] Row;
    int[] Column;
    int Diag;
    int AntiDiag;
    int N;
    
    /** Initialize your data structure here. */
    public TicTacToe(int n) {
        Row = new int[n];
        Column = new int[n];
        N = n;
    }
    
    /** Player {player} makes a move at ({row}, {col}).
        @param row The row of the board.
        @param col The column of the board.
        @param player The player, can be either 1 or 2.
        @return The current winning condition, can be either:
                0: No one wins.
                1: Player 1 wins.
                2: Player 2 wins. */
    public int Move(int row, int col, int player) {
        int mark = player==1?1:-1;
        Row[row] += mark;
        if(Row[row] == N) return 1;
        else if (Row[row] == -N) return 2;
        
        Column[col] += mark;
        if(Column[col] == N) return 1;
        else if (Column[col] == -N) return 2;
        
        if(row == col){
            Diag += mark;
            if(Diag == N) return 1;
            else if (Diag == -N) return 2;
        }
        
        if(row == N-col-1){
            AntiDiag += mark;
            if(AntiDiag == N) return 1;
            else if (AntiDiag == -N) return 2;
        }
        
        return 0;
    }
}

/**
 * Your TicTacToe object will be instantiated and called as such:
 * TicTacToe obj = new TicTacToe(n);
 * int param_1 = obj.Move(row,col,player);
 */
