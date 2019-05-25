//https://leetcode.com/problems/sparse-matrix-multiplication/

//Sparse => 0 checks

public class Solution {
    public int[,] Multiply(int[,] A, int[,] B) {
        int a = A.GetLength(0);
        int b = A.GetLength(1);
        int c = B.GetLength(1);
        int[,] C = new int[a, c];
        for(int i = 0; i < a; i++){
            for(int k = 0; k < b; k++){
                if(A[i, k] == 0) continue;
                for(int j = 0; j < c; j++){                
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }
        return C;
    }
}
