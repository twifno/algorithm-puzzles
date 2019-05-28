//https://leetcode.com/problems/minimum-swaps-to-make-sequences-increasing/

public class Solution {
    public int MinSwap(int[] A, int[] B) {
        int len = A.Length;
        if(len == 0) return 0;
        int[] nonswap = new int[len];
        int[] swap = new int[len];
        nonswap[0] = 0;
        swap[0] = 1;
        for(int i = 1; i < len; i++){
            if(A[i] > A[i-1] && B[i] > B[i-1]) {
                if(A[i] > B[i-1] && B[i] > A[i-1]) {
                    nonswap[i] = Math.Min(nonswap[i-1], swap[i-1]);
                    swap[i] = Math.Min(swap[i-1]+1, nonswap[i-1]+1);
                } else {
                    nonswap[i] = nonswap[i-1];
                    swap[i] = swap[i-1]+1;
                }
            } else {
                nonswap[i] = swap[i-1];
                swap[i] = nonswap[i-1]+1;
            }
            
        }
        return Math.Min(nonswap[len-1], swap[len-1]);
    }
}
