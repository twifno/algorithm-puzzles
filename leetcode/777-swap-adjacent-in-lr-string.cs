//https://leetcode.com/problems/swap-adjacent-in-lr-string/

public class Solution {
    public bool CanTransform(string start, string end) {
        if(start.Replace("X","") != end.Replace("X","")) return false;
        int rCount = 0;
        int lCount = 0;
        for(int i = 0; i < start.Length; i++){
            if(start[i] == 'R') rCount += 1;
            if(start[i] == 'L') lCount += 1;
            if(end[i] == 'R') rCount -= 1;
            if(end[i] == 'L') lCount -= 1;
            if(rCount < 0 || lCount > 0) return false;
        }
        return true;
    }
}
