//https://leetcode.com/problems/word-ladder/

//BFS

public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        Dictionary<string, List<string>> g = new Dictionary<string, List<string>>();
        g[beginWord] = new List<string>();
        foreach(string s in wordList){
            if(IsLink(beginWord, s)) g[beginWord].Add(s);
        }
        //foreach(string s in g.Keys) System.Console.WriteLine(g[s].Count);
        for(int i = 0; i < wordList.Count; i++){
            for(int j = 0; j < wordList.Count; j++){
                if(i == j) continue;
                if(IsLink(wordList[i], wordList[j])){
                    if(!g.ContainsKey(wordList[i])) g[wordList[i]] = new List<string>();
                    g[wordList[i]].Add(wordList[j]);
                }
            }
        }
        //foreach(string s in g.Keys) System.Console.WriteLine(g[s].Count);
        return Shortest(beginWord, endWord, g);
    }
    
    class QueueNode {
        public string val;
        public int step;
        public QueueNode(string v, int s){
            val = v;
            step = s;
        }
    }
    
    private int Shortest(string beginWord, string endWord, Dictionary<string, List<string>> g){
        HashSet<string> visited = new HashSet<string>();
        Queue<QueueNode> q = new Queue<QueueNode>();
        q.Enqueue(new QueueNode(beginWord, 1));
        visited.Add(beginWord);
        while(q.Count>0){
            QueueNode node = q.Dequeue();
            //System.Console.WriteLine(node.val);
            if(node.val == endWord) return node.step;
            if(g.ContainsKey(node.val)){
                foreach(string next in g[node.val]){
                    if(!visited.Contains(next)){
                        visited.Add(next);
                        q.Enqueue(new QueueNode(next, node.step+1));
                    }
                }
            }
        }
        return 0;
    }
    
    private bool IsLink(string s1, string s2){
        int count = 0;
        for(int i = 0; i < s1.Length; i++){
            if(s1[i] != s2[i]) {
                count += 1;
                if(count > 1) return false;
            }
        }
        return true;
    }
}
