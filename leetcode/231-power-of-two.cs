//https://leetcode.com/problems/power-of-two/

public class Solution {
    public bool IsPowerOfTwo(int n) {
        if(n <= 0) return false;
        return n == (n & -n);
    }
}

//It can be !(n & (n-1)) as well.
