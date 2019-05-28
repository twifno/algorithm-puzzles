//https://leetcode.com/problems/keyboard-row/

public class Solution {
    public string[] FindWords(string[] words) {
        int[] rows = {2,3,3,2,1,2,2,2,1,2,2,2,3,3,1,1,1,1,2,1,1,3,1,3,1,3};
        List<string> res = new List<string>();
        foreach(string s in words){
            string up = s.ToUpper();
            int row = rows[up[0] - 'A'];
            bool sr = true;
            foreach(char c in up){
                if(row != rows[c-'A']) sr = false;
            }
            if(sr) res.Add(s);
        }
        return res.ToArray();
    }
}
