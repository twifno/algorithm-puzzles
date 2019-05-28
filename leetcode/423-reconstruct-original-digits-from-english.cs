//https://leetcode.com/problems/reconstruct-original-digits-from-english/

public class Solution {
    public string OriginalDigits(string s) {
        int[] counts = new int[26];
        foreach(char c in s) counts[c-'a'] += 1;
        int[] digits = new int[10];
        digits[0] = counts[25];
        digits[2] = counts['w'-'a'];
        digits[8] = counts['g'-'a'];
        digits[3] = counts['h'-'a'] - digits[8];
        digits[6] = counts['x'-'a'];
        digits[4] = counts['r'-'a'] - digits[0] - digits[3];
        digits[1] = counts['o'-'a'] - digits[0] - digits[2] - digits[4];
        digits[5] = counts['f'-'a'] - digits[4];
        digits[7] = counts['v'-'a'] - digits[5];
        digits[9] = counts['i'-'a'] - digits[5] - digits[6] - digits[8];
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < 10; i++){
            for(int j = 0; j < digits[i]; j++){
                sb.Append(i);
            }
        }
        return sb.ToString();
    }
}
