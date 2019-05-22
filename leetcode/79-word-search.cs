//https://leetcode.com/problems/word-search/

//Back tracking…

public class Solution {
    public bool Exist(char[,] board, string word) {
        int l0 = board.GetLength(0);
        int l1 = board.GetLength(1);
        bool[,] visit = new bool[l0, l1];
        for(int i = 0; i < l0; i++){
            for(int j = 0; j < l1; j++){
                if(Find(i, j, 0, word, visit, board)) return true;
            }
        }
        return false;
    }
    
    private bool Find(int r, int c, int idx, string word, bool[,] visit, char[,] board){
        if(idx == word.Length) return true;
        if(r < 0 || r >= board.GetLength(0) || c < 0 || c >= board.GetLength(1)) return false;
        if(board[r, c] != word[idx]) return false;
        if(visit[r, c] == true) return false;
        visit[r, c] = true;
        if(Find(r-1, c, idx+1, word, visit, board)) return true;
        if(Find(r, c-1, idx+1, word, visit, board)) return true;
        if(Find(r+1, c, idx+1, word, visit, board)) return true;
        if(Find(r, c+1, idx+1, word, visit, board)) return true;
        visit[r, c] = false;
        return false;
    }
}
