//https://leetcode.com/problems/set-matrix-zeroes/

//Utilize first row and first column to save 0 information.

public class Solution {
    public void SetZeroes(int[,] matrix) {
        bool row0 = false;
        bool column0 = false;
        int l0 = matrix.GetLength(0);
        int l1 = matrix.GetLength(1);
        for(int i = 0; i < l0; i++) if(matrix[i, 0] == 0) column0 = true;
        for(int j = 0; j < l1; j++) if(matrix[0, j] == 0) row0 = true;
        for(int i = 1; i < l0; i++){
            for(int j = 1; j < l1; j++){
                if(matrix[i, j] == 0){
                    matrix[0, j] = 0;
                    matrix[i, 0] = 0;
                }
            }    
        }
        for(int i = 1; i < l0; i++){
            if(matrix[i, 0] == 0) {
                for(int j = 1; j < l1; j++) matrix[i, j] = 0;
            }
        }
        for(int j = 1; j < l1; j++){
            if(matrix[0, j] == 0){
                for(int i = 0; i < l0; i++) matrix[i, j] = 0;
            }
        }
        if(row0 == true) for(int j = 0; j < l1; j++) matrix[0, j] = 0;
        if(column0 == true) for(int i = 0; i < l0; i++) matrix[i, 0] = 0;
    }
}
