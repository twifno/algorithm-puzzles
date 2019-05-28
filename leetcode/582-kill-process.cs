//https://leetcode.com/problems/kill-process/

public class Solution {
    public IList<int> KillProcess(IList<int> pid, IList<int> ppid, int kill) {
        Dictionary<int, List<int>> adj = new Dictionary<int, List<int>>();
        for(int i = 0; i < pid.Count; i++){
            if(ppid[i] != 0){
                if(!adj.ContainsKey(ppid[i])) adj[ppid[i]] = new List<int>();
                adj[ppid[i]].Add(pid[i]);
            }
        }
        Stack<int> st = new Stack<int>();
        st.Push(kill);
        List<int> res = new List<int>();
        while(st.Count > 0){
            int id = st.Pop();
            res.Add(id);
            if(adj.ContainsKey(id)) foreach(int cid in adj[id]) st.Push(cid);
        }
        return res;
    }
}
