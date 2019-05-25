//https://leetcode.com/problems/power-of-four/

public class Solution {
    public bool IsPowerOfFour(int num) {
        if(num == 0) return false;
        if((num & (num-1)) != 0) return false;
        int mask = 0X55555555;
        if((mask & num) == 0) return false;
        return true;
    }
}
