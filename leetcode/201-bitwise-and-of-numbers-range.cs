//https://leetcode.com/problems/bitwise-and-of-numbers-range/

//Removing unequal tailing 1s

public class Solution {
    public int RangeBitwiseAnd(int m, int n) {
        int count = 0;
        while(n != m){
            n >>= 1;
            m >>= 1;
            count += 1;
        }
        return n << count;
    }
}
