//https://leetcode.com/problems/replace-words/

//Classic Trie..

public class Solution {
    class TrieNode {
        public bool IsWord;
        public TrieNode[] Children;
        public TrieNode(bool isWord){
            IsWord = isWord;
            Children = new TrieNode[26];
        }
    }
    
    TrieNode Root;
    
    private void Add(string s){
        TrieNode node = Root;
        foreach(char c in s){
            int index = c - 'a';
            if(node.Children[index] == null) {
                node.Children[index] = new TrieNode(false);
            }
            node = node.Children[index];
        }
        node.IsWord = true;
    }
    
    private string FindPrefix(string s){
        TrieNode node = Root;
        for(int i = 0; i < s.Length; i++){
            if(node.IsWord) return s.Substring(0, i);
            int index = s[i] - 'a';
            if(node.Children[index] == null) return s;
            node = node.Children[index];
        }
        return s;
    }
    
    public string ReplaceWords(IList<string> dict, string sentence) {
        Root = new TrieNode(false);
        foreach(string w in dict) Add(w);
        string[] words = sentence.Split(" ");
        for(int i = 0; i < words.Length; i++){
            string w = words[i];
            if(w.Length <= 1) continue;
            words[i] = FindPrefix(w);
        }
        return string.Join(' ', words);
    }
}
