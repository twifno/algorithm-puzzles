//https://leetcode.com/problems/best-meeting-point/

public class Solution {
    public int MinTotalDistance(int[][] grid) {
        int l0 = grid.Length;
        int l1 = grid[0].Length;
        List<int> rows = new List<int>();
        List<int> cols = new List<int>();
        for(int i = 0; i < l0; i++){
            for(int j = 0; j < l1; j++){
                if(grid[i][j] == 1) {
                    rows.Add(i);
                    cols.Add(j);
                }
            }
        }
        cols.Sort();
        int dist = 0;
        int left = 0;
        int right = rows.Count-1;
        while(left < right){
            dist += rows[right] - rows[left];
            left += 1;
            right -= 1;
        }
        left = 0;
        right = cols.Count-1;
        while(left < right){
            dist += cols[right] - cols[left];
            left += 1;
            right -= 1;
        }
        return dist;
    }
}
