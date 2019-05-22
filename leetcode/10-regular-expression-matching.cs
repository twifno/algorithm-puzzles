//https://leetcode.com/problems/regular-expression-matching/

//DP

public class Solution {
    public bool IsMatch(string s, string p) {
        int ls = s.Length;
        int lp = p.Length;
        bool[,] match = new bool[ls+1, lp+1];
        match[ls, lp] = true;
        for(int i = ls; i >= 0; i--) {
            for(int j = lp-1; j >= 0; j--) {
                if(j < lp-1 && p[j+1] == '*') {
                    match[i, j] = match[i, j+2];
                    if(i < ls && (s[i] == p[j] || p[j] == '.')) {
                        match[i, j] = match[i, j] || match[i+1, j];
                    }
                } else if(i < ls && (s[i] == p[j] || p[j] == '.')) {
                    match[i, j] = match[i+1, j+1];
                }
            }
        }
        return match[0, 0];
    }
}
