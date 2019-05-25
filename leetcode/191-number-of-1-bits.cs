//https://leetcode.com/problems/number-of-1-bits/

public class Solution {
    public int HammingWeight(uint n) {
        int res = 0;
        for(int i = 0; i < 32; i++){
            res += (int)(n & 1);
            n >>= 1;
            //System.Console.WriteLine(n & 1);
        }
        return res;
    }
}
