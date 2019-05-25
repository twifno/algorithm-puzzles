//https://leetcode.com/problems/word-search-ii/

//Use prefix tree to cut down search domain..

public class Solution {
    public IList<string> FindWords(char[,] board, string[] words) {
        Root = new TrieNode();
        int l0 = board.GetLength(0);
        int l1 = board.GetLength(1);
        Build(words);
        
        bool[,] visited = new bool[l0, l1];
        HashSet<string> res = new HashSet<string>();
        StringBuilder cur = new StringBuilder();
        for(int i = 0; i < l0; i++){
            for(int j = 0; j < l1; j++){
                Find(i, j, board, cur, visited, res);
            }
        }
        return res.ToList();
    }
    
    private void Build(string[] words){
        foreach(string w in words){
            Insert(w);
        }
    }
    
    private void Find(int r, int c, char[,] board, StringBuilder cur, bool[,] visited, HashSet<string> res){
        cur.Append(board[r, c]);
        visited[r, c] = true;
        bool prefix;
        String s = cur.ToString();
        if(Search(s, out prefix)) res.Add(s);
        if(prefix) {
            if(r > 0 && !visited[r-1, c]) { Find(r-1, c, board, cur, visited, res); }
            if(c > 0 && !visited[r, c-1]) { Find(r, c-1, board, cur, visited, res); }
            if(r < board.GetLength(0)-1 && !visited[r+1, c]) { Find(r+1, c, board, cur, visited, res); }
            if(c < board.GetLength(1)-1 && !visited[r, c+1]) { Find(r, c+1, board, cur, visited, res); }
        }
        cur.Length -= 1;
        visited[r, c] = false;
    }
    
    class TrieNode {
        public TrieNode[] Children;
        public bool IsWord;
        public TrieNode(){
            Children = new TrieNode[26];
        }
    }
    
    TrieNode Root;
    
    private void Insert(string w){
        TrieNode cur = Root;
        for(int i = 0; i < w.Length; i++){
            int index = w[i] - 'a';
            if(cur.Children[index] == null) cur.Children[index] = new TrieNode();
            cur = cur.Children[index];
        }
        cur.IsWord = true;
    }
    
    private bool Search(string w, out bool prefix){
        TrieNode cur = Root;
        for(int i = 0; i < w.Length; i++){
            int index = w[i] - 'a';
            if(cur.Children[index] == null) { prefix = false; return false;}
            cur = cur.Children[index];
        }
        prefix = true;
        return cur.IsWord;
    }
}
