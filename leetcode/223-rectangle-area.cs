//https://leetcode.com/problems/rectangle-area/

//Be careful on the non-overlap case..

public class Solution {
    public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H) {
        int a1 = (C-A)*(D-B);
        int a2 = (G-E)*(H-F);
        int olA = Math.Max(A, E);
        int olB = Math.Max(B, F);
        int olC = Math.Min(C, G);
        int olD = Math.Min(D, H);
        if(olC <= olA || olD <= olB) return a1+a2;
        int a3 = (olC-olA)*(olD-olB);
        return a1+a2-a3;
    }
}
