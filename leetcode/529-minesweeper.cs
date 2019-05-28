//https://leetcode.com/problems/minesweeper/

public class Solution {
    public char[][] UpdateBoard(char[][] board, int[] click) {
        int x = click[0];
        int y = click[1];
        if(board[x][y] == 'M') {
            board[x][y] = 'X';
            return board;
        }
        Dfs(x, y, board);
        return board;
    }
    
    private int Count(int x, int y, char[][] board){
        int count = 0;
        for(int i = -1; i <= 1; i++) {
            for(int j = -1; j <= 1; j++){
                if(i == 0 && j == 0) continue;
                if(i+x < 0 || i+x >= board.Length) continue;
                if(j+y < 0 || j+y >= board[0].Length) continue;
                if(board[i+x][j+y] == 'M') count += 1;
            }
        }
        return count;
    }
    
    private void Dfs(int x, int y, char[][] board){
        int count = Count(x, y, board);
        if(count > 0) {
            board[x][y] = (char)('0'+count);
            return;
        }
        board[x][y] = 'B';
        for(int i = -1; i <= 1; i++) {
            for(int j = -1; j <= 1; j++){
                if(i == 0 && j == 0) continue;
                if(i+x < 0 || i+x >= board.Length) continue;
                if(j+y < 0 || j+y >= board[0].Length) continue;
                if(board[i+x][j+y] != 'E') continue;
                Dfs(i+x, j+y, board);
            }
        }
    }
}
