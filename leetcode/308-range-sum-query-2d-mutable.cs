//https://leetcode.com/problems/range-sum-query-2d-mutable/

//Binary Indexed Tree

public class NumMatrix {

    int[,] BIT;
    int L0;
    int L1;
    
    public NumMatrix(int[][] matrix) {
        L0 = matrix.Length;
        if(L0 == 0) return;
        L1 = matrix[0].Length;
        BIT = new int[L0+1, L1+1];
        for(int i = 0; i < L0; i++){
            for(int j = 0; j < L1; j++){
                Update(i, j, matrix[i][j]);
            }
        }
    }
    
    public void Update(int row, int col, int val) {
        val -= SumRegion(row, col, row, col);
        row += 1;
        col += 1;
        for(int r = row; r <= L0; r += r & -r){
            for(int c = col; c <= L1; c += c & -c){
                BIT[r, c] += val;
            }
        }
    }
    
    public int Sum(int row, int col) {
        row += 1;
        col += 1;
        int sum = 0;
        for(int r = row; r >= 1; r -= r & -r){
            for(int c = col; c >= 1; c -= c & -c){
                sum += BIT[r, c];
            }
        }
        return sum;
    }
    
    private void Print() {
        for(int i = 1; i <= L0; i++){
            for(int j = 1; j <= L1; j++){
                System.Console.Write(BIT[i, j] + ",");
            }
            System.Console.WriteLine("|");
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        //Print();
        if(row1 == 0 && col1 == 0) return Sum(row2, col2);
        else if(row1 == 0) return Sum(row2, col2) - Sum(row2, col1-1);
        else if(col1 == 0) return Sum(row2, col2) - Sum(row1-1, col2);
        else return Sum(row2, col2) + Sum(row1-1, col1-1) - Sum(row2, col1-1) - Sum(row1-1, col2);
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * obj.Update(row,col,val);
 * int param_2 = obj.SumRegion(row1,col1,row2,col2);
 */
