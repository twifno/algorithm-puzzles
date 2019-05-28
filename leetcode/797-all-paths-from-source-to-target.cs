//https://leetcode.com/problems/all-paths-from-source-to-target/

public class Solution {
    class Node {
        public int Val;
        public List<int> Path;
        public Node(int v, List<int> p){
            Val = v;
            Path = new List<int>(p);
            Path.Add(v);
        }
    }
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
        int n = graph.Length;
        Node s = new Node(0, new List<int>());
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(s);
        List<IList<int>> res = new List<IList<int>>();
        while(q.Count > 0){
            Node cur = q.Dequeue();
            if(cur.Val == n-1) res.Add(cur.Path);
            else {
                foreach(int t in graph[cur.Val]){
                    q.Enqueue(new Node(t, cur.Path));
                }
            }
        }
        return res;
    }
}
