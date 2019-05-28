//https://leetcode.com/problems/number-complement/

public class Solution {
    public int FindComplement(int num) {
        int b = 1;
        int res = 0;
        while(num != 0){
            if((num & 1) == 0) {
                res |= b;
            }
            num >>= 1;
            b <<= 1;
        }
        return res;
    }
}
