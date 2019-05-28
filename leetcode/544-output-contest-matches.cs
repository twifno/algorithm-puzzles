//https://leetcode.com/problems/output-contest-matches/

public class Solution {
    public string FindContestMatch(int n) {
        string[] matches = new string[n];
        for(int i = 0; i < n; i++) matches[i] = (i+1).ToString();
        FindMatch(n, matches);
        return matches[0];
    }
    
    private void FindMatch(int n, string[] matches){
        if(n == 1) return;
        for(int i = 0; i < n/2; i++){
            matches[i] = "(" + matches[i] + "," + matches[n-i-1] + ")";
        }
        FindMatch(n/2, matches);
    }
}
