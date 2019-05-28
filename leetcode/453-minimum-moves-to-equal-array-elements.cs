//https://leetcode.com/problems/minimum-moves-to-equal-array-elements/

public class Solution {
    public int MinMoves(int[] nums) {
        int min = Int32.MaxValue;
        foreach(int n in nums) min = Math.Min(min, n);
        int sum = 0;
        foreach(int n in nums) sum += n - min;
        return sum;
    }
}
