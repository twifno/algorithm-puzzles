//https://leetcode.com/problems/longest-common-prefix/

//Solve by Trie, but it can be done in a easier way.

public class Solution {
    class TrieNode {
        public char val;
        public int size;
        public TrieNode[] children;
        public TrieNode(char val){
            this.val = val;
            size = 1;
            children = new TrieNode[26];
        }
    }
    
    class Trie {
        TrieNode trie = new TrieNode(' ');
        internal void Add(string s){
            int cur = 0;
            TrieNode curNode = trie;
            while(cur < s.Length){
                int index = s[cur]-'a';
                if(curNode.children[index] == null){
                    TrieNode node = new TrieNode(s[cur]);
                    curNode.children[index] = node;
                    cur += 1;
                    curNode = node;
                } else {
                    curNode = curNode.children[index];
                    curNode.size += 1;
                    cur += 1;
                }
            }
        }
        internal string FindPrefix(string s, int len){
            StringBuilder sb = new StringBuilder();
            TrieNode curNode = trie;
            int cur = 0;
            while(cur < s.Length && curNode.children[s[cur]-'a'].size == len){
                sb.Append(s[cur]);
                curNode = curNode.children[s[cur]-'a'];
                cur += 1;
            }
            return sb.ToString();
        }
    }
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length == 0) return "";
        Trie t = new Trie();
        foreach(string s in strs){
            t.Add(s);
        }
        return t.FindPrefix(strs[0], strs.Length);
    }
}
