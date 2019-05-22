//https://leetcode.com/problems/plus-one/

public class Solution {
    public int[] PlusOne(int[] digits) {
        for(int i = digits.Length-1; i >= 0; i--){
            digits[i] += 1;
            if(digits[i] < 10) return digits;
            else digits[i] = 0;
        }
        int[] newDigits = new int[digits.Length+1];
        newDigits[0] = 1;
        return newDigits;
    }
}
