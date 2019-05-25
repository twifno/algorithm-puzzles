//https://leetcode.com/problems/factorial-trailing-zeroes/

public class Solution {
    public int TrailingZeroes(int n) {
        if(n == 0) return 0;
        return n/5 + TrailingZeroes(n/5);
    }
}




//Iterative solution - be careful about overflow.

public class Solution {
    public int TrailingZeroes(int n) {
        int count = 0;
        int b = 5;
        while(n / b != 0){
            count += n/b;
            if(b*5/5 != b) break;
            b *= 5;
        }
        return count;
    }
}
