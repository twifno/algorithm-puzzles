//https://leetcode.com/problems/reverse-vowels-of-a-string/

public class Solution {
    public string ReverseVowels(string s) {
        int left = 0;
        int right = s.Length-1;
        char[] chars = s.ToCharArray();
        while(left < right){
            while(left < chars.Length && !isVowel(chars[left])) left += 1;
            while(right >= 0 && !isVowel(chars[right])) right -= 1;
            if(left < right) {
                char tmp = chars[left];
                chars[left] = chars[right];
                chars[right] = tmp;
                left += 1;
                right -= 1;
            }
        }
        return new string(chars);
    }
    
    private bool isVowel(char c){
        if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c =='u') return true;
        if(c == 'A' || c == 'E' || c == 'I' || c == 'O' || c =='U') return true;
        return false;
    }
}
