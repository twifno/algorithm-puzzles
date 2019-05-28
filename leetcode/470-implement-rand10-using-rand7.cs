//https://leetcode.com/problems/implement-rand10-using-rand7/

/**
 * The Rand7() API is already defined in the parent class SolBase.
 * public int Rand7();
 * @return a random integer in the range 1 to 7
 */
public class Solution : SolBase {
    public int Rand10() {
        int next = (Rand7()-1)*7 + Rand7();
        if(next <= 40) return next % 10 + 1;
        else return Rand10();
    }
}
