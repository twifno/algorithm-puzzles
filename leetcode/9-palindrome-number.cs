//https://leetcode.com/problems/palindrome-number/

public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0) return false;
        if(x == Reverse(x)) return true;
        return false;
    }
    
    private int Reverse(int x) {
        int rev = 0;
        while(x != 0){
            if(rev == (rev * 10 + x % 10) / 10) { rev = rev*10 + x % 10; x /= 10;}
            else return 0;
        }
        return rev;
    }
}
