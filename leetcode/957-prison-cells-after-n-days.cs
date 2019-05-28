//https://leetcode.com/problems/prison-cells-after-n-days/

public class Solution {
    public int[] PrisonAfterNDays(int[] cells, int N) {
        Dictionary<string, int> occurs = new Dictionary<string, int>();
        int cur = 0;
        while(cur < N) {            
            string key = string.Join("", cells);
            if(occurs.ContainsKey(key)) {
                int period = cur - occurs[key];
                cur += (N-cur)/period*period;
                break;
            }
            occurs[key] = cur;
            Next(cells);
            cur += 1;
        }
        while(cur < N) {
            Next(cells);
            cur += 1;
        }
        return cells;
    }
    
    private void Next(int[] cells) {
        int[] c = new int[cells.Length];
        for(int i = 0; i < cells.Length; i++){
            if(i == 0 || i == cells.Length-1 || cells[i-1] != cells[i+1]) c[i] = 0;
            else c[i] = 1;
        }
        for(int i = 0; i < c.Length; i++){
            cells[i] = c[i];
        }
    }
}
