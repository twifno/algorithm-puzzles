//https://leetcode.com/problems/valid-palindrome/

public class Solution {
    public bool IsPalindrome(string s) {
        System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex("[^A-Za-z0-9]");
        s = r.Replace(s, "").ToLower();
        int left = 0;
        int right = s.Length-1;
        while(left <= right){
            if(s[left] != s[right]) return false;
            left += 1;
            right -= 1;
        }
        return true;
    }
}