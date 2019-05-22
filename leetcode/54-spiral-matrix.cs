//https://leetcode.com/problems/spiral-matrix/

//Layer by layer approach…
//Need to be very careful with the corner cases.

public class Solution {
    public IList<int> SpiralOrder(int[,] matrix) {
        int l0 = matrix.GetLength(0);
        int l1 = matrix.GetLength(1);
        int lv = Math.Min(l0, l1);
        lv = (lv+1)/2;
        List<int> res = new List<int>();
        for(int i = 0; i < lv; i++){
            for(int j = i; j < l1-i-1; j++){
                res.Add(matrix[i, j]);
            }
            if(l0 % 2 == 1 && i == (l0-1)/2) {
                res.Add(matrix[i, l1-i-1]);
                continue;
            }
            for(int j = i; j < l0-i-1; j++){
                res.Add(matrix[j, l1-i-1]);
            }
            if(l1 % 2 == 1 && i == (l1-1)/2) {
                res.Add(matrix[l0-i-1, l1-i-1]);
                continue;
            }
            for(int j = l1-i-1; j > i; j--){
                res.Add(matrix[l0-i-1, j]);
            }
            for(int j = l0-i-1; j > i; j--){
                res.Add(matrix[j, i]);
            }

        }
        return res;
    }
}
