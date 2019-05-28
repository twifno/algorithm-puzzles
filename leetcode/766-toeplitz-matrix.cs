//https://leetcode.com/problems/toeplitz-matrix/

public class Solution {
    public bool IsToeplitzMatrix(int[,] matrix) {
        int l0 = matrix.GetLength(0);
        int l1 = matrix.GetLength(1);
        for(int i = 0; i < l0; i++){
            for(int j = 0; j < l1; j++){
                if(i > 0 && j > 0 && matrix[i-1,j-1] != matrix[i,j]) return false;
            }
        }
        return true;
    }
}
