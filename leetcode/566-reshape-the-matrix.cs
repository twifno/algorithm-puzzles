//https://leetcode.com/problems/reshape-the-matrix/

public class Solution {
    public int[,] MatrixReshape(int[,] nums, int r, int c) {
        int l0 = nums.GetLength(0);
        int l1 = nums.GetLength(1);
        int count = l0 * l1;
        if(r*c != count) return nums;
        int[,] res = new int[r, c];
        for(int i = 0; i < count; i++){
            res[i/c, i%c] = nums[i/l1, i%l1];
        }
        return res;
    }
}
