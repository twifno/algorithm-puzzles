//https://leetcode.com/problems/add-and-search-word-data-structure-design/

//Trie

public class WordDictionary {
    class TrieNode {
        public bool IsWord;
        public TrieNode[] Children;
        public TrieNode(){
            Children = new TrieNode[26];
        }
    }
    
    TrieNode Root;

    /** Initialize your data structure here. */
    public WordDictionary() {
        Root = new TrieNode();
    }
    
    /** Adds a word into the data structure. */
    public void AddWord(string word) {
        TrieNode cur = Root;
        for(int i = 0; i < word.Length; i++){
            int index = word[i] - 'a';
            if(cur.Children[index] == null) cur.Children[index] = new TrieNode();
            cur = cur.Children[index];
        }
        cur.IsWord = true;
    }
    
    private bool Search(string word, TrieNode node){
        for(int i = 0; i < word.Length; i++){
            if(word[i] == '.'){
                string sub = word.Substring(i+1, word.Length-i-1);
                for(int j = 0; j < 26; j++){
                    if(node.Children[j] != null && Search(sub, node.Children[j])) return true;
                }
                return false;
            } else {
                int index = word[i] - 'a';
                if(node.Children[index] == null) return false;
                node = node.Children[index];
            }
        }
        return node.IsWord;
        
    }
    
    /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
    public bool Search(string word) {
        return Search(word, Root);
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */
