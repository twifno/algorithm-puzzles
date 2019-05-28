//https://leetcode.com/problems/image-smoother/

public class Solution {
    public int[,] ImageSmoother(int[,] M) {
        int l0 = M.GetLength(0);
        int l1 = M.GetLength(1);
        int[,] N = new int[l0, l1];
        for(int i = 0; i < l0; i++){
            for(int j = 0; j < l1; j++){
                int sum = 0;
                int count = 0;
                for(int x = -1; x <= 1; x++){
                    for(int y = -1; y <= 1; y++){
                        if(x + i < 0) continue;
                        if(x + i >= l0) continue;
                        if(y + j < 0) continue;
                        if(y + j >= l1) continue;
                        
                        sum += M[x+i, y+j];
                        count += 1;
                    }
                }
                N[i, j] = sum / count;
            }
        }
        
        return N;
    }
}
