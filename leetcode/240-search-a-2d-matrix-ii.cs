//https://leetcode.com/problems/search-a-2d-matrix-ii/

//Eliminate one row or one column at a time

public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        int l0 = matrix.GetLength(0);
        int l1 = matrix.GetLength(1);
        int i = 0;
        int j = l1-1;
        while(i < l0 && j >= 0){
            if(matrix[i, j] == target) return true;
            else if (matrix[i, j] < target) {
                i += 1;
            } else {
                j -= 1;
            }
        }
        return false;
    }
}
