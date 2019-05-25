//https://leetcode.com/problems/range-sum-query-2d-immutable/

public class NumMatrix {

    int[,] sums;
    
    public NumMatrix(int[,] matrix) {
        sums = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for(int i = 0; i < matrix.GetLength(0); i++){
            for(int j = 0; j < matrix.GetLength(1); j++){
                if(i == 0 && j == 0){
                    sums[i, j] = matrix[i, j];
                } else if (i == 0) {
                    sums[i, j] = sums[i, j-1] + matrix[i, j];
                } else if (j == 0) {
                    sums[i, j] = sums[i-1, j] + matrix[i, j];
                } else {
                    sums[i, j] = sums[i-1, j] + sums[i, j-1] - sums[i-1, j-1] + matrix[i, j];
                }
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        if(row1 == 0 && col1 == 0) return sums[row2, col2];
        else if(row1 == 0) return sums[row2, col2] - sums[row2, col1-1];
        else if(col1 == 0) return sums[row2, col2] - sums[row1-1, col2];
        else return sums[row2, col2] - sums[row2, col1-1] - sums[row1-1, col2] + sums[row1-1, col1-1];
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */
