//https://leetcode.com/problems/alien-dictionary/

//Topological sort + detect cycle.

public class Solution {
    public string AlienOrder(string[] words) {
        Dictionary<char, List<char>> g = new Dictionary<char, List<char>>();
        int len = words.Length;
        for(int i = 0; i < len; i++) AddNode(words[i], g);
        
        for(int i = 0; i < len-1; i++) {
            for(int j = i+1; j < len; j++){
                Update(words[i], words[j], g);
            }
        }
        
        List<char> res = new List<char>();
        HashSet<char> visited = new HashSet<char>();
        foreach(char key in g.Keys) {
            if(!visited.Contains(key)) {
                HashSet<char> thisVisit = new HashSet<char>();
                if(!Visit(key, g, res, visited, thisVisit)) return "";
            }
        }
        return new string(res.ToArray());
    }
    
    private void AddNode(string w1, Dictionary<char, List<char>> g) {
        foreach(char c in w1) if(!g.ContainsKey(c)) g[c] = new List<char>();
    }
    
    private void Update(string w1, string w2, Dictionary<char, List<char>> g) {
        int cur = 0;
        while(cur < w1.Length && cur < w2.Length){
            if(w1[cur] != w2[cur]) {
                g[w1[cur]].Add(w2[cur]);
                return;
            }
            cur += 1;
        }
    }
    
    private bool Visit(char key, Dictionary<char, List<char>> g, List<char> res, HashSet<char> visited, HashSet<char> thisVisit) {
        //System.Console.WriteLine(key);
        visited.Add(key);
        thisVisit.Add(key);
        if(g.ContainsKey(key)) {
            foreach(char next in g[key]){
                if(thisVisit.Contains(next)) return false;
                if(!visited.Contains(next)) {
                    bool v = Visit(next, g, res, visited, thisVisit);
                    if(!v) return false;
                }
            }
        }
        res.Insert(0, key);
        thisVisit.Remove(key);
        return true;
    }
}
