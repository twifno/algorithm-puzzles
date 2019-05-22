//https://leetcode.com/problems/word-ladder-ii/

//Bfs

public class Solution {
    public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList) {
        Dictionary<string, HashSet<string>> g = new Dictionary<string, HashSet<string>>();
        g[beginWord] = new HashSet<string>();
        foreach(string s in wordList){
            if(IsLink(beginWord, s)) g[beginWord].Add(s);
        }
        for(int i = 0; i < wordList.Count; i++){
            for(int j = 0; j < wordList.Count; j++){
                if(i == j) continue;
                if(IsLink(wordList[i], wordList[j])){
                    if(!g.ContainsKey(wordList[i])) g[wordList[i]] = new HashSet<string>();
                    g[wordList[i]].Add(wordList[j]);
                }
            }
        }
        List<QueueNode> nodes = Shortest(beginWord, endWord, g);
        List<IList<string>> res = new List<IList<string>>();
        for(int i = 0; i < nodes.Count; i++) {
            QueueNode node = nodes[i];
            Stack<string> st = new Stack<string>();
            while(node != null) {
                st.Push(node.val);
                node = node.Parent;
            }
            res.Add(st.ToList());
        }
        return res;
    }
        
    
    class QueueNode {
        public string val;
        public int step;
        public QueueNode Parent;
        public QueueNode(string v, int s, QueueNode p){
            val = v;
            step = s;
            Parent = p;
        }
    }
    
    private List<QueueNode> Shortest(string beginWord, string endWord, Dictionary<string, HashSet<string>> g){
        List<QueueNode> res = new List<QueueNode>();
        Dictionary<string, int> visited = new Dictionary<string, int>();
        Queue<QueueNode> q = new Queue<QueueNode>();
        q.Enqueue(new QueueNode(beginWord, 1, null));
        visited[beginWord] = 1;
        while(q.Count>0){
            QueueNode node = q.Dequeue();
            if(node.val == endWord) res.Add(node);
            else if(g.ContainsKey(node.val)){
                foreach(string next in g[node.val]){
                    if(!visited.ContainsKey(next) || visited[next] >= node.step+1){
                        visited[next] = node.step+1;
                        q.Enqueue(new QueueNode(next, node.step+1, node));
                    }
                }
            }
        }
        return res;
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
