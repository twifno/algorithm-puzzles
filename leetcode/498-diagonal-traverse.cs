//https://leetcode.com/problems/diagonal-traverse/

//Layer = i+j

public class Solution {
    public int[] FindDiagonalOrder(int[,] matrix) {
        int l0 = matrix.GetLength(0);
        int l1 = matrix.GetLength(1);
        int[] res = new int[l0 * l1];
        int cur = 0;
        for(int i = 0; i < l0+l1-1; i++){
            if(i % 2 == 0){
                for(int j = 0; j <= i; j++){
                    if(j >= l1) break;
                    if(i-j >= l0) j = i-l0+1;
                    res[cur] = matrix[i-j, j];
                    cur += 1;
                }
            } else {
                for(int j = 0; j <= i; j++){
                    if(j >= l0) break;
                    if(i-j >= l1) j = i-l1+1;
                    res[cur] = matrix[j, i-j];
                    cur += 1;
                }
            }
        }
        return res;
    }
}
