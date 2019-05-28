//https://leetcode.com/problems/lonely-pixel-i/

//Count the column and rows.

public class Solution {
    public int FindLonelyPixel(char[,] picture) {
        int l0 = picture.GetLength(0);
        int l1 = picture.GetLength(1);
        int[] rcount = new int[l0];
        int[] ccount = new int[l1];
        int[] pr = new int[l0];
        for(int i = 0; i < l0; i++){
            for(int j = 0; j < l1; j++){
                if(picture[i, j] == 'B'){
                    rcount[i] += 1;
                    ccount[j] += 1;
                    pr[i] = j;
                }
            }
        }
        int sum = 0;
        for(int i = 0; i < l0; i++){
            if(rcount[i] == 1) {
                int c = pr[i];
                if(ccount[c] == 1) sum += 1;
            }
        }
        return sum;
    }
}
