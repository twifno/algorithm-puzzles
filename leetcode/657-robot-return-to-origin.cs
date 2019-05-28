//https://leetcode.com/problems/robot-return-to-origin/

public class Solution {
    public bool JudgeCircle(string moves) {
        int x = 0;
        int y = 0;
        foreach(char c in moves){
            if(c == 'U') y += 1;
            else if(c == 'D') y -= 1;
            else if(c == 'L') x -= 1;
            else if(c == 'R') x += 1;
        }
        return x == 0 && y == 0;
    }
}
