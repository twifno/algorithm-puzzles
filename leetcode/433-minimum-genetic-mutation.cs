//https://leetcode.com/problems/minimum-genetic-mutation/

//Classic BFS

public class Solution {
    class Mutation {
        public string State;
        public int Count;
        public Mutation(string s, int c){
            State = s;
            Count = c;
        }
    }
    
    public int MinMutation(string start, string end, string[] bank) {
        Dictionary<string, List<string>> adj = new Dictionary<string, List<string>>();
        HashSet<string> visited = new HashSet<string>();
        adj[start] = new List<string>();
        foreach(string s in bank){
            if(Link(start, s)) adj[start].Add(s);
        }
        for(int i = 0; i < bank.Length-1; i++){
            for(int j = 0; j < bank.Length; j++){
                if(Link(bank[i], bank[j])){
                    if(!adj.ContainsKey(bank[i])) adj[bank[i]] = new List<string>();
                    adj[bank[i]].Add(bank[j]);
                    if(!adj.ContainsKey(bank[j])) adj[bank[j]] = new List<string>();
                    adj[bank[j]].Add(bank[i]);
                }
            }
        }
        Queue<Mutation> q = new Queue<Mutation>();
        q.Enqueue(new Mutation(start, 0));
        while(q.Count > 0){
            Mutation m = q.Dequeue();
            visited.Add(m.State);
            if(m.State == end) return m.Count;
            if(adj.ContainsKey(m.State)){
                foreach(string s in adj[m.State]){
                    if(!visited.Contains(s)){
                        q.Enqueue(new Mutation(s, m.Count+1));
                    }
                }
            }
        }
        return -1;
    }
    
    private bool Link(string s1, string s2){
        int count = 0;
        for(int i = 0; i < s1.Length; i++){
            if(s1[i] != s2[i]) count += 1;
        }
        return count == 1;
    }
}
