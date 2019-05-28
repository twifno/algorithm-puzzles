//https://leetcode.com/problems/rotate-string/

public class Solution {
    public bool RotateString(string A, string B) {
        if(A.Length != B.Length) return false;
        if((A+A).IndexOf(B) != -1) return true;
        return false;
    }
}
