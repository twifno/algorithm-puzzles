//https://leetcode.com/problems/network-delay-time/

public class Solution {
    public int NetworkDelayTime(int[][] times, int N, int K) {
        Dictionary<int, List<Edge>> map = new Dictionary<int, List<Edge>>();
        int l0 = times.Length;
        if(l0 == 0) return -1;
        for(int i = 0; i < l0; i++) {
            int u = times[i][0];
            int v = times[i][1];
            int w = times[i][2];
            if(!map.ContainsKey(u)) map[u] = new List<Edge>();
            map[u].Add(new Edge(v, w));
        }
        SortedSet<Node> q = new SortedSet<Node>();
        bool[] visited = new bool[N+1];
        int max = 0;
        q.Add(new Node(K, 0));
        while(q.Count > 0) {
            Node n = q.Min;
            q.Remove(n);
            if(visited[n.Dest]) continue;
            visited[n.Dest] = true;
            max = Math.Max(max, n.Weight);
            if(map.ContainsKey(n.Dest)) {
                foreach(Edge e in map[n.Dest]) {
                    if(!visited[e.Dest]) q.Add(new Node(e.Dest, n.Weight+e.Weight));
                }
            }
        }
        for(int i = 1; i <= N; i++) if(!visited[i]) return -1;
        return max;
    }
    
    class Node: IComparable<Node> {
        public int Dest;
        public int Weight;
        public Node(int d, int w){
            Dest = d;
            Weight = w;
        }
        public int CompareTo(Node o){
            if(Weight == o.Weight) return Dest.CompareTo(o.Dest);
            return Weight.CompareTo(o.Weight);
        }
    }
    
    class Edge {
        public int Dest;
        public int Weight;
        public Edge(int d, int w){
            Dest = d;
            Weight = w;
        }
    }
}
