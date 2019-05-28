//https://leetcode.com/problems/valid-square/

public class Solution {
    public bool ValidSquare(int[] p1, int[] p2, int[] p3, int[] p4) {
        long len12 = GetLen(p1, p2);
        long len13 = GetLen(p1, p3); 
        long len14 = GetLen(p1, p4); 
        long len23 = GetLen(p2, p3); 
        long len24 = GetLen(p2, p4); 
        long len34 = GetLen(p3, p4);
        
        if(len12 == 0) return false;
        
        if(len12 == len23 && len12 == len34 && len12 == len14 && len13 == len24) return true;
        if(len13 == len34 && len13 == len24 && len13 == len12 && len23 == len14) return true;
        if(len13 == len23 && len13 == len24 && len13 == len14 && len12 == len34) return true;
        return false;
    }
    
    private long GetLen(int[] p1, int[] p2){
        return (p1[0] - p2[0])*(long)(p1[0] - p2[0]) + (p1[1] - p2[1])*(long)(p1[1] - p2[1]);
    }
}
