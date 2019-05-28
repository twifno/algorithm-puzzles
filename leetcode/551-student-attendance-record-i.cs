//https://leetcode.com/problems/student-attendance-record-i/

public class Solution {
    public bool CheckRecord(string s) {
        if(s.Contains("LLL")) return false;
        int pos = s.IndexOf('A');
        if(pos == -1) return true;
        pos = s.IndexOf('A', pos+1);
        if(pos == -1) return true;
        return false;
    }
}
