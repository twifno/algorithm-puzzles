//https://leetcode.com/problems/reverse-words-in-a-string-ii/

//Reverse the whole sentence and then reverse each word.

public class Solution {
    public void ReverseWords(char[] str) {
        Array.Reverse(str);
        int left = 0;
        int right = 0;
        while(right < str.Length){
            if(str[right] == ' ') {
                Array.Reverse(str, left, right-left);
                left = right+1;
            }
            right += 1;
        }
        Array.Reverse(str, left, str.Length-left);
    }
}
