//https://leetcode.com/problems/reconstruct-itinerary/

//Topological sort.

public class Solution {
    public IList<string> FindItinerary(string[][] tickets) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        int count = 0;
        for(int i = 0; i < tickets.GetLength(0); i++){
            string f = tickets[i][0];
            string t = tickets[i][1];
            if(!map.ContainsKey(f)) map[f] = new List<string>();
            map[f].Add(t);
            count += 1;
        }
        foreach(string s in map.Keys) {
            map[s].Sort();
        }
        string cur = "JFK";
        List<string> iti = new List<string>();
        Dfs(cur, map, iti);
        return iti;
    }
    
    private void Dfs(string cur, Dictionary<string, List<string>> map, List<string> iti){
        while(map.ContainsKey(cur) && map[cur].Count > 0) {
            string dest = map[cur][0];
            map[cur].RemoveAt(0);
            Dfs(dest, map, iti);  
        }
        iti.Insert(0, cur);
    }
}
