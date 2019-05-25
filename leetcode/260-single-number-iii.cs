//https://leetcode.com/problems/single-number-iii/

//!! Two single number must be different in at least one bit..

public class Solution {
    public int[] SingleNumber(int[] nums) {
        int xor = 0;
        foreach(int n in nums) xor ^= n;
        int lastBit = xor & (-xor);
        int first = 0;
        foreach(int n in nums) if((lastBit & n) != 0) first ^= n;
        int second = xor ^ first;
        return new int[2]{first, second};
    }
}
