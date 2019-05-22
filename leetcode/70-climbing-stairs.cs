//https://leetcode.com/problems/climbing-stairs/

//Fibonacci number.

public class Solution {
    public int ClimbStairs(int n) {
        if (n == 1) return 1;
        int b = 1;
        int cur = 1;
        for(int i = 1; i < n; i++){
            cur += b;
            b = cur - b;
        }
        return cur;
    }
}
