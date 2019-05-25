//https://leetcode.com/problems/count-numbers-with-unique-digits/

//Be careful with n=0

public class Solution {
    public int CountNumbersWithUniqueDigits(int n) {
        if(n == 0) return 1;
        if(n > 10) return CountNumbersWithUniqueDigits(10);
        if(n == 1) return 10;
        int b = 9;
        int count = 9;
        int start = n-1;
        while(start > 0){
            count *= b;
            b -= 1;
            start -= 1;
        }
        return count + CountNumbersWithUniqueDigits(n-1);
    }
}


