//https://leetcode.com/problems/shortest-palindrome/

public class Solution {
    public string ShortestPalindrome(string s) {
        for(int i = s.Length; i > 0; i--){
            if(IsPalindrome(s, 0, i-1)){
                StringBuilder sb = new StringBuilder(s);
                for(int j = i; j < s.Length; j++){
                    sb.Insert(0, s[j]);
                }
                return sb.ToString();
            }
        }
        return "";
    }
    
    private bool IsPalindrome(string s, int left, int right){
        while(left < right){
            if(s[left] != s[right]) return false;
            left += 1;
            right -= 1;
        }
        return true;
    }
}

//KMP

