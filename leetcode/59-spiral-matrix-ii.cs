//https://leetcode.com/problems/spiral-matrix-ii/

//A simple solution - can be made to be more efficient

public class Solution {
    public int[,] GenerateMatrix(int n) {
        int[,] m = new int[n,n];
        int cur = 1;
        for(int i = 0; i < (n+1)/2; i++){
            for(int j = 0; j < n; j++){
                if(m[i, j] == 0) { 
                    m[i, j] = cur;
                    cur += 1;
                }
            }
            for(int j = 0; j < n; j++){
                if(m[j, n-i-1] == 0) {
                    m[j, n-1-i] = cur;
                    cur += 1;
                }
            }
            for(int j = n-1; j >= 0; j--){
                if(m[n-i-1, j] == 0) {
                    m[n-i-1, j] = cur;
                    cur += 1;
                }
            }
            for(int j = n-1; j >= 0; j--){
                if(m[j, i] == 0) {
                    m[j, i] = cur;
                    cur += 1;
                }
            }
        }
        return m;
    }
}
