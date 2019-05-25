//https://leetcode.com/problems/palindrome-pairs/

//Trie - program carefully.

public class Solution {
    class TrieNode {
        public TrieNode[] Children;
        public bool IsWord;
        public int Pos;
        public List<int> Candidates;
        public TrieNode() {
            Children = new TrieNode[26];
            Candidates = new List<int>();
        }
    }
    
    private void Add(string w, int pos, TrieNode head){
        int len = w.Length;
        for(int i = len-1; i >= 0; i--){
            int idx = w[i] - 'a';
            if(IsPal(w, 0, i)) head.Candidates.Add(pos);
            if(head.Children[idx] == null) head.Children[idx] = new TrieNode();
            head = head.Children[idx];
        }
        head.Candidates.Add(pos);
        head.IsWord = true;
        head.Pos = pos;
    }
    
    private void FindPair(string w, int pos, TrieNode head, List<IList<int>> res){
        int len = w.Length;
        for(int i = 0; i < len; i++){
            if(head.IsWord && IsPal(w, i, len-1)) {
                if(pos != head.Pos) res.Add(CreatePair(pos, head.Pos));
            }
            int idx = w[i] - 'a';
            if(head.Children[idx] == null) return;
            head = head.Children[idx];
        }
        foreach(int c in head.Candidates){
            if(pos == c) continue;
            res.Add(CreatePair(pos, c));
        }
    }
    
    private List<int> CreatePair(int a, int b){
        List<int> pair = new List<int>();
        pair.Add(a);
        pair.Add(b);
        return pair;
    }
    
    private bool IsPal(string w, int l, int r){
        while(l < r){
            if(w[l++] != w[r--]) return false;
        }
        return true;
    }
    
    public IList<IList<int>> PalindromePairs(string[] words) {
        TrieNode head = new TrieNode();
        for(int i = 0; i < words.Length; i++){
            Add(words[i], i, head);
        }
        List<IList<int>> res = new List<IList<int>>();
        for(int i = 0; i < words.Length; i++){
            FindPair(words[i], i, head, res);
        }
        return res;
    }
}
