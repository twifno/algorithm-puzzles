//https://leetcode.com/problems/counting-bits/

public class Solution {
    public int[] CountBits(int num) {
        int[] bits = new int[num+1];
        for(int i = 1; i <= num; i++){
            bits[i] = 1 + bits[i&(i-1)];
        }
        return bits;
    }
}
