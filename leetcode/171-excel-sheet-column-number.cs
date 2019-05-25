//https://leetcode.com/problems/excel-sheet-column-number/

public class Solution {
    public int TitleToNumber(string s) {
        int b = 1;
        int num = 0;
        for(int i = s.Length-1; i >= 0; i--){
            num += b * (s[i] - 'A' + 1);
            b *= 26;
        }
        return num;
    }
}
