//https://leetcode.com/problems/elimination-game/

//Done by recursion..

public class Solution {
    public int LastRemaining(int n) {
        return LastRemaining(n, true);
    }
    
    private int LastRemaining(int n, bool ltr){
        if(n == 1) return 1;
        if(n == 2) if(ltr) return 2; else return 1;
        if(ltr) {
            return 2*LastRemaining(n/2, !ltr);
        } else {
            if(n % 2 == 0){
                return 2*LastRemaining(n/2, !ltr) - 1;
            } else {
                return 2*LastRemaining(n/2, !ltr);
            }
        }
    }
}
