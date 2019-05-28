//https://leetcode.com/problems/sum-of-square-numbers/

//Also can use Fermat Theorem.

public class Solution {
    public bool JudgeSquareSum(int c) {
        for(int i = 0; i <= Math.Sqrt(c); i++){
            int rem = c - i*i;
            if(rem < i*i) break;
            if((int)Math.Sqrt(rem) == Math.Sqrt(rem)) return true;
        }
        return false;
    }
}
