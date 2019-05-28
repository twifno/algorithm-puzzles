//https://leetcode.com/problems/minimum-index-sum-of-two-lists/

public class Solution {
    public int MaxCount(int m, int n, int[,] ops) {
        for(int i = 0; i < ops.GetLength(0); i++){
            m = Math.Min(m, ops[i, 0]);
            n = Math.Min(n, ops[i, 1]);
        }
        return m*n;
    }
}
