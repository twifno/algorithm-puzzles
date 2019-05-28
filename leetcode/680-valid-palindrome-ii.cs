//https://leetcode.com/problems/valid-palindrome-ii/

//Greedy, skip the difference.

public class Solution {
    public bool ValidPalindrome(string s) {
        int left = 0; int right = s.Length-1;
        bool isPal = true;
        while(left < right){
            if(s[left] != s[right]) {
                isPal = false;
                break;
            }
            left += 1;
            right -= 1;
        }
        if(isPal) return true;
        left = 0;
        right = s.Length-1;
        bool skipped = false;
        isPal = true;
        while(left < right){
            if(s[left] != s[right]) {
                if(!skipped) {
                    left += 1;
                    skipped = true;
                }
                else {
                    isPal = false;
                    break;
                }
            } else {
                left += 1;
                right -= 1;
            }
        }
        if(isPal) return true;
        left = 0;
        right = s.Length-1;
        skipped = false;
        isPal = true;
        while(left < right){
            if(s[left] != s[right]) {
                if(!skipped) {                
                    right -= 1;
                    skipped = true;
                }
                else {
                    isPal = false;
                    break;
                }
            } else {
                left += 1;
                right -= 1;
            }
        }
        if(isPal) return true;
        return false;
    }
}
