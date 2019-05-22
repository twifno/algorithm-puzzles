//https://leetcode.com/problems/divide-two-integers/

//This question needs to be very carefully on the boundary case.

public class Solution {
    public int Divide(int dividend, int divisor) {
        if(dividend == Int32.MinValue && divisor == -1) return Int32.MaxValue;
        if(dividend == Int32.MinValue && divisor == Int32.MinValue) return 1;
        if(divisor == Int32.MinValue) return 0;
        int q = 0;
        if(dividend == Int32.MinValue){
            q = 1;
            if(divisor > 0) dividend += divisor;
            else dividend -= divisor;
        }
        bool neg = false;
        if(dividend < 0) {
            neg = !neg;
            dividend = -dividend;
        }
        if(divisor < 0) {
            neg = !neg;
            divisor = -divisor;
        }
        while (dividend >= divisor){
            int p = divisor;
            int b = 1;
            while(p<1073741824 && p+p <= dividend){
                p += p;
                b += b;
            }
            q += b;
            dividend -= p;
        }
        if(neg) q = -q;
        return q;
    }
}
