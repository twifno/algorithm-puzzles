//https://leetcode.com/problems/assign-cookies/

//Greedy

public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);
        int count = 0;
        int curG = 0;
        int curS = 0;
        while(curS < s.Length && curG < g.Length){
            if(s[curS] >= g[curG]){
                curS += 1;
                curG += 1;
                count += 1;
            } else curS += 1;
        }
        return count;
    }
}
