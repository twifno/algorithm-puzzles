//https://leetcode.com/problems/longest-palindrome/

public class Solution {
    public int LongestPalindrome(string s) {
        int[] counts = new int[128];
        foreach(char c in s){
            counts[c-'\0'] += 1;
        }
        bool hasOdd = false;
        int sum = 0;
        foreach(int count in counts){
            if(count % 2 == 0) sum += count;
            else {
                hasOdd = true;
                sum += count - 1;
            }
        }
        if(hasOdd) sum += 1;
        return sum;
    }
}
