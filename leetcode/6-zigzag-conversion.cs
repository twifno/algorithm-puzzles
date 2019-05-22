//https://leetcode.com/problems/zigzag-conversion/

//Math - calculate the repeated pattern

public class Solution {
    public string Convert(string s, int numRows) {
        if(numRows == 1) return s;
        StringBuilder sb = new StringBuilder();
        int gs = numRows*2 - 2;
        for(int i = 0; i < numRows; i++){
            for(int j = 0; j+i < s.Length; j += gs){
                sb.Append(s[j+i]);
                if(i != 0 && i != numRows-1 && j+gs-i < s.Length) sb.Append(s[j+gs-i]);
            }
        }
        return sb.ToString();
    }
}
