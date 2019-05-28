//https://leetcode.com/problems/hamming-distance/

public class Solution {
    public int HammingDistance(int x, int y) {
        int xor = x ^ y;
        int count = 0;
        while(xor != 0){
            xor &= (xor-1);
            count += 1;
        }
        return count;
    }
} 
