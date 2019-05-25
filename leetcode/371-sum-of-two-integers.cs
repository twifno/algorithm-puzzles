//https://leetcode.com/problems/sum-of-two-integers/

public class Solution {
    public int GetSum(int a, int b) {
        if(a == 0) return b;
        if(b == 0) return a;
        int carry = 0;
        while(b != 0){
            carry = a & b;
            a = a ^ b;
            b = carry << 1;
        }
        return a;
    }
}
