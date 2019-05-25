//https://leetcode.com/problems/happy-number/

//The real problem - cycle detection

public class Solution {
    public bool IsHappy(int n) {
        int fast = Next(Next(n));
        int slow = Next(n);
        while(fast != slow){
            fast = Next(Next(fast));
            slow = Next(slow);
        }
        if(fast == 1) return true;
        else return false;
    }
    
    private int Next(int n){
        int res = 0;
        while(n > 0){
            int r = n % 10;
            n /= 10;
            res += r*r;
        }
        return res;
    }
}
