//https://leetcode.com/problems/graph-valid-tree/

//BFS

public class Solution {
    public bool ValidTree(int n, int[,] edges) {
        List<int>[] adj = new List<int>[n];
        for(int i = 0; i < n; i++) adj[i] = new List<int>();
        for(int i = 0; i < edges.GetLength(0); i++){
            int source = edges[i, 0];
            int target = edges[i, 1];
            adj[source].Add(target);
            adj[target].Add(source);
        }
        bool[] visited = new bool[n];
        Queue<int> q = new Queue<int>();
        q.Enqueue(0);
        int count = 0;
        while(q.Count > 0){
            int node = q.Dequeue();
            visited[node] = true;
            count += 1;
            int vc = 0;
            foreach(int adjn in adj[node]){
                if(visited[adjn]) vc += 1;
                else q.Enqueue(adjn);
            }
            if(vc > 1) return false;
        }
        if(count == n) return true;
        return false;
    }
}


//Can also be done by DFS/Union set etc
