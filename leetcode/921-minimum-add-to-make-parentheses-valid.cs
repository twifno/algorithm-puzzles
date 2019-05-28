//https://leetcode.com/problems/minimum-add-to-make-parentheses-valid/

public class Solution {
    public int MinAddToMakeValid(string S) {
        int count = 0;
        int changes = 0;
        foreach(char c in S){
            if(c == '(') count += 1;
            else {
                if(count > 0) count -= 1;
                else changes += 1;
            }
        }
        return count + changes;
    }
}
