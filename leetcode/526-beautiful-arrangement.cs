//https://leetcode.com/problems/beautiful-arrangement/

public class Solution {
    Dictionary<int, List<int>> Map;
    
    public int CountArrangement(int N) {
        Map = new Dictionary<int, List<int>>();
        for(int i = 1; i <= N; i++){
            for(int j = 1; j <= N; j++){
                if(i % j == 0 || j % i == 0){
                    if(!Map.ContainsKey(i)) Map[i] = new List<int>();
                    Map[i].Add(j);
                }
            }
        }
        
        bool[] visited = new bool[N+1];
        
        return Find(visited, 1, N);
    }
        
    private int Find(bool[] visited, int pos, int N){
        if(pos > N) return 1;
        int sum = 0;
        foreach(int n in Map[pos]) {
            if(!visited[n]) {
                visited[n] = true;
                sum += Find(visited, pos+1, N);
                visited[n] = false;
            }
        }
        return sum;
    }
}
