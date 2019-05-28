//https://leetcode.com/problems/is-graph-bipartite/

public class Solution {
    
    public bool IsBipartite(int[][] graph) {
        int len = graph.Length;
        int[] colors = new int[len];
        for(int i = 0; i < len; i++){
            if(colors[i] != 0) continue;
            Queue<int> q = new Queue<int>();
            colors[i] = 1;
            q.Enqueue(i);
            while(q.Count > 0){
                int n = q.Dequeue();
                foreach(int o in graph[n]){
                    if(colors[o] == colors[n]) return false;
                    else if (colors[o] == 0) {
                        if(colors[n] == 1) colors[o] = 2;
                        else colors[o] = 1;
                        q.Enqueue(o);
                    }
                }
            }
        }
        return true;
    }
}
