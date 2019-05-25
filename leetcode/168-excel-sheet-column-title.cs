//https://leetcode.com/problems/excel-sheet-column-title/

public class Solution {
    public string ConvertToTitle(int n) {
        char[] dict = new char[26] { 'Z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y'};
        StringBuilder sb = new StringBuilder();       
        while(n != 0){
            int r = n % 26;
            sb.Insert(0, dict[r]);
            if(r == 0) n -= 26;
            n = n / 26;
        }
        return sb.ToString();
    }
}
