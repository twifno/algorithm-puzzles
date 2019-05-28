//https://leetcode.com/problems/number-of-segments-in-a-string/

public class Solution {
    public int CountSegments(string s) {
        string[] ss = s.Split(" ");
        int count = 0;
        foreach(string str in ss){
            if(str.Length > 0) count += 1;
        }
        return count;
    }
}
