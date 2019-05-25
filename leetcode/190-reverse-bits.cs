//https://leetcode.com/problems/reverse-bits/

public class Solution {
    public uint reverseBits(uint n) {
        uint res = 0;
        for(int i = 0; i < 32; i++){
            res = res*2 + (n & 1);
            n >>= 1;
            //System.Console.WriteLine(n & 1);
        }
        return res;
    }
}

//There are better bit-wise solution
