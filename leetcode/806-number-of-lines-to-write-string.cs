//https://leetcode.com/problems/number-of-lines-to-write-string/

public class Solution {
    public int[] NumberOfLines(int[] widths, string S) {
        if(S.Length == 0) return new int[]{0, 0};
        int cur = 0;
        int line = 1;
        foreach(char c in S){
            int len = widths[c-'a'];
            if(cur + len > 100){
                line += 1;
                cur = len;
            } else cur += len;
        }
        return new int[2] {line, cur};
    }
}
