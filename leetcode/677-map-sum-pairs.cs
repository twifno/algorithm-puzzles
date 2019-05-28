//https://leetcode.com/problems/map-sum-pairs/

public class MapSum {

    class TrieNode {
        public TrieNode[] Children;
        public int Total;
        public int Val;
        public bool IsWord;
        public TrieNode(){
            Children = new TrieNode[26];
        }
    } 
    
    TrieNode Root;
    
    private void Add(string word, int val){
        TrieNode cur = Root;
        for(int i = 0; i < word.Length; i++){
            int idx = word[i] - 'a';
            if(cur.Children[idx] == null) cur.Children[idx] = new TrieNode();
            cur = cur.Children[idx];
            cur.Total += val;
        }
        cur.IsWord = true;
        cur.Val += val;
    }
    
    private bool Find(string word, out int val){
        TrieNode cur = Root;
        val = 0;
        for(int i = 0; i < word.Length; i++){
            int idx = word[i] - 'a';
            if(cur.Children[idx] == null) return false;
            cur = cur.Children[idx];
        }
        if(cur.IsWord) { val = cur.Val; return true; }
        return false;
    }
    
    private int FindPrefix(string prefix){
        TrieNode cur = Root;
        for(int i = 0; i < prefix.Length; i++){
            int idx = prefix[i] - 'a';
            if(cur.Children[idx] == null) return 0;
            cur = cur.Children[idx];
        }
        return cur.Total;
    }
    
    /** Initialize your data structure here. */
    public MapSum() {
        Root = new TrieNode();
    }
    
    public void Insert(string key, int val) {
        int prev;
        bool isWord = Find(key, out prev);
        if(isWord) val -= prev;
        Add(key, val);
    }
    
    public int Sum(string prefix) {
        return FindPrefix(prefix);
    }
}

/**
 * Your MapSum object will be instantiated and called as such:
 * MapSum obj = new MapSum();
 * obj.Insert(key,val);
 * int param_2 = obj.Sum(prefix);
 */
