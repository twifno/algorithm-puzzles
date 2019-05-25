//https://leetcode.com/problems/implement-trie-prefix-tree/

public class Trie {
    class TrieNode {
        public TrieNode[] Children;
        public bool IsWord;
        public TrieNode(){
            Children = new TrieNode[26];
        }
    }

    TrieNode Root;
    
    /** Initialize your data structure here. */
    public Trie() {
        Root = new TrieNode();
    }
    
    /** Inserts a word into the trie. */
    public void Insert(string word) {
        TrieNode cur = Root;
        for(int i = 0; i < word.Length; i++){
            int index = word[i] - 'a';
            if(cur.Children[index] == null) cur.Children[index] = new TrieNode();
            cur = cur.Children[index];
        }
        cur.IsWord = true;
    }
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) {
        TrieNode cur = Root;
        for(int i = 0; i < word.Length; i++){
            int index = word[i] - 'a';
            if(cur.Children[index] == null) return false;
            cur = cur.Children[index];
        }
        return cur.IsWord;
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix) {
        TrieNode cur = Root;
        for(int i = 0; i < prefix.Length; i++){
            int index = prefix[i] - 'a';
            if(cur.Children[index] == null) return false;
            cur = cur.Children[index];
        }
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
