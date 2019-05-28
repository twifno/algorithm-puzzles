//https://leetcode.com/problems/word-squares/

//Backtracking…
//Can be solved by Trie as well.

public class Solution {
    public IList<IList<string>> WordSquares(string[] words) {
        List<IList<string>> res = new List<IList<string>>();
        List<string> cur = new List<string>();
        Dictionary<char, List<string>> map = new Dictionary<char, List<string>>();
        foreach(string s in words){
            char head = s[0];
            if(!map.ContainsKey(head)) map[head] = new List<string>();
            map[head].Add(s);
        }
        
        foreach(string s in words){
            char head = s[0];
            cur.Add(s);
            Find(map, cur, res);
            cur.RemoveAt(cur.Count-1);
        }
        
        return res;
    }
    
    private void Find(Dictionary<char, List<string>> map, List<string> cur, List<IList<string>> res){
        int layer = cur.Count;
        if(layer >= cur[0].Length) {
            res.Add(new List<string>(cur));
            return;
        }
        char head = cur[0][layer];
        if(!map.ContainsKey(head)) return;
        foreach(string s in map[head]){
            if(Check(cur, s)){
                cur.Add(s);
                Find(map, cur, res);
                cur.RemoveAt(cur.Count-1);
            }
        }
    }
    
    private bool Check(List<string> cur, string next){
        for(int i = 0; i < cur.Count; i++){
            if(next[i] != cur[i][cur.Count]) return false;
        }
        return true;
    }
}
