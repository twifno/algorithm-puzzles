//https://leetcode.com/problems/friend-circles/

public class Solution {
    public int FindCircleNum(int[,] M) {
        int len = M.GetLength(0);
        bool[] visited = new bool[len];
        int sum = 0;
        for(int i = 0; i < len; i++){
            if(!visited[i]) {
                sum += 1;
                Visit(i, M, visited);
            }
        }
        return sum;
    }
    
    private void Visit(int pos, int[,] M, bool[] visited){
        visited[pos] = true;
        for(int i = 0; i < M.GetLength(0); i++){
            if(M[pos, i] == 1 && !visited[i]) Visit(i, M, visited);
        }
    }
}
