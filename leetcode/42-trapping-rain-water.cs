//https://leetcode.com/problems/trapping-rain-water/

//Barrel effect - trapped water = min(left barrel, right barrel) - base.

public class Solution {
    public int Trap(int[] height) {
        int max = 0;
        int[] lmax = new int[height.Length];
        for(int i = 0; i < height.Length; i++){
            max = Math.Max(max, height[i]);
            lmax[i] = max;
        }
        max = 0;
        int[] rmax = new int[height.Length];
        for(int i = height.Length-1; i >= 0; i--){
            max = Math.Max(max, height[i]);
            rmax[i] = max;
        }
        int count = 0;
        for(int i = 0; i < height.Length; i++){
            count += Math.Min(lmax[i], rmax[i]) - height[i];
        }
        return count;
    }
}
