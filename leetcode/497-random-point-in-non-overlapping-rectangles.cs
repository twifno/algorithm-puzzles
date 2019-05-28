//https://leetcode.com/problems/random-point-in-non-overlapping-rectangles/

//Remember +1 when calculating areas.

public class Solution {
    
    int Sum;
    int[] Sums;
    int[][] Rects;
    Random Rand;
    
    public Solution(int[][] rects) {
        Rects = rects;
        int len = rects.Length;
        Sums = new int[len];
        Sum = 0;
        for(int i = 0; i < len; i++){
            Sum += (rects[i][2] - rects[i][0] + 1) * (rects[i][3] - rects[i][1] + 1);
            Sums[i] = Sum;
        }
        Rand = new Random();
    }
    
    public int[] Pick() {
        double next = Rand.NextDouble() * Sum;
        int pos = 0;
        while(Sums[pos] <= next) pos += 1;
        int xlen = Rand.Next(Rects[pos][2] - Rects[pos][0] + 1);
        int ylen = Rand.Next(Rects[pos][3] - Rects[pos][1] + 1);
        return new int[2] { Rects[pos][0] + xlen, Rects[pos][1] + ylen};
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(rects);
 * int[] param_1 = obj.Pick();
 */
