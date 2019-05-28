//https://leetcode.com/problems/binary-number-with-alternating-bits/

public class Solution {
    public bool HasAlternatingBits(int n) {
        int last = n & 1;
        n = n >> 1;
        while(n != 0){
            if(last == (n & 1)) return false;
            last = n & 1;
            n = n >> 1;
        }
        return true;
    }
}
