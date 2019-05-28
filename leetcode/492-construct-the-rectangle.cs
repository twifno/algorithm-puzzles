//https://leetcode.com/problems/construct-the-rectangle/

public class Solution {
    public int[] ConstructRectangle(int area) {
        int w = (int)Math.Sqrt(area);
        while(area % w != 0) w -= 1;
        return new int[2]{area/w, w};
    }
}
