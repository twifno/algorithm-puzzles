//https://leetcode.com/problems/fibonacci-number/

public class Solution {
    public int Fib(int N) {
        if(N == 0) return 0;
        if(N == 1) return 1;
        return Fib(N-1) + Fib(N-2);
    }
}
