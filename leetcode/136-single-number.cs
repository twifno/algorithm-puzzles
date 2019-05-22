//https://leetcode.com/problems/single-number/

public class Solution {
    public int SingleNumber(int[] nums) {
        int odd = 0;
        foreach(int n in nums) odd ^= n;
        return odd;
    }
}
