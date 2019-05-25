//https://leetcode.com/problems/palindrome-permutation/

public class Solution {
    public bool CanPermutePalindrome(string s) {
        int[] counts = new int[128];
        foreach(char c in s){
            counts[c - '\0'] += 1;
        }
        int odds = 0;
        foreach(int c in counts) if(c%2 == 1) odds += 1;
        return odds <= 1;
    }
}
