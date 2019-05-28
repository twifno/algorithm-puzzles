//https://leetcode.com/problems/implement-magic-dictionary/

//Trie

public class MagicDictionary {

    class TrieNode{
        public TrieNode[] Children;
        public bool IsWord;
        public TrieNode() {
            Children = new TrieNode[26];
        }
    }
    
    TrieNode Root;
    
    private void Add(string word){
        TrieNode cur = Root;
        for(int i = 0; i < word.Length; i++){
            int idx = word[i] - 'a';
            if(cur.Children[idx] == null) cur.Children[idx] = new TrieNode();
            cur = cur.Children[idx];
        }
        cur.IsWord = true;
    }
    
    private bool ExclFind(string word, char excl, int pos, TrieNode cur){
        if(pos == word.Length) return cur.IsWord;
        char c = word[pos];
        if(c == '*'){
            for(int i = 0; i < 26; i++){
                if(i == excl - 'a') continue;
                if(cur.Children[i] != null && ExclFind(word, excl, pos+1, cur.Children[i])) return true;
            }
            return false;
        } else {
            int idx = c - 'a';
            if(cur.Children[idx] != null) {
                return ExclFind(word, excl, pos+1, cur.Children[idx]);
            } else {
                return false;
            }
        }
    }
    
    /** Initialize your data structure here. */
    public MagicDictionary() {
        Root = new TrieNode();
    }
    
    /** Build a dictionary through a list of words */
    public void BuildDict(string[] dict) {
        foreach(string s in dict) Add(s);
    }
    
    /** Returns if there is any word in the trie that equals to the given word after modifying exactly one character */
    public bool Search(string word) {
        char[] cs = word.ToCharArray();
        for(int i = 0; i < cs.Length; i++){
            char excl = cs[i];
            cs[i] = '*';
            if(ExclFind(new string(cs), excl, 0, Root)) return true;
            cs[i] = excl;
        }
        return false;
    }
}

/**
 * Your MagicDictionary object will be instantiated and called as such:
 * MagicDictionary obj = new MagicDictionary();
 * obj.BuildDict(dict);
 * bool param_2 = obj.Search(word);
 */
