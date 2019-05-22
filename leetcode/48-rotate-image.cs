//https://leetcode.com/problems/rotate-image/

//Handle a quarter of the matrix

public class Solution {
    public void Rotate(int[,] matrix) {
        int l0 = matrix.GetLength(0);
        int l1 = matrix.GetLength(1);
        for(int i = 0; i < l0/2; i++){
            for(int j = 0; j < (l1+1)/2; j++){
                int tmp = matrix[i, j];
                matrix[i, j] = matrix[l0-j-1, i];
                matrix[l0-j-1, i] = matrix[l0-i-1, l1-j-1];
                matrix[l0-i-1, l1-j-1] = matrix[j, l1-i-1];
                matrix[j, l1-i-1]  = tmp;
            }
        }
    }
}

