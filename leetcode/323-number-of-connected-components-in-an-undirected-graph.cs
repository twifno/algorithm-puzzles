//https://leetcode.com/problems/number-of-connected-components-in-an-undirected-graph/

//BFS

public class Solution {
    public int CountComponents(int n, int[,] edges) {
        Dictionary<int, List<int>> g = new Dictionary<int, List<int>>();
        for(int i = 0; i < edges.GetLength(0); i++){
            int n1 = edges[i, 0];
            int n2 = edges[i, 1];
            if(!g.ContainsKey(n1)) g[n1] = new List<int>();
            if(!g.ContainsKey(n2)) g[n2] = new List<int>();
            g[n1].Add(n2);
            g[n2].Add(n1);
        }
        bool[] visited = new bool[n];
        int count = 0;
        for(int i = 0; i < n; i++){
            if(!visited[i]){
                count += 1;
                Queue<int> q = new Queue<int>();
                q.Enqueue(i);
                while(q.Count > 0){
                    int node = q.Dequeue();
                    visited[node] = true;
                    if(g.ContainsKey(node)){
                        foreach(int nd in g[node]){
                            if(!visited[nd]) q.Enqueue(nd);
                        }
                    }
                }
            }
        }
        return count;
    }
}

//Union Set

public class Solution {
    public int CountComponents(int n, int[,] edges) {
        int[] parent = new int[n];
        for(int i = 0; i < n; i++) parent[i] = i;
        
        for(int i = 0; i < edges.GetLength(0); i++){
            int n1 = edges[i, 0];
            int n2 = edges[i, 1];
            int p1 = Find(n1, parent);
            int p2 = Find(n2, parent);
            if(p1 != p2){
                n -= 1;
                parent[p1] = p2;
            }
        }
        
        return n;
    }
    
    int Find(int node, int[] parent){
        while(parent[node] != node){
            parent[node] = parent[parent[node]];
            node = parent[node];
        }
        return node;
    }
}

