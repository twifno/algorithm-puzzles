//https://leetcode.com/problems/repeated-string-match/

//Also can be solved by Rabin-Karp (Rolling Hash)?

public class Solution {
    public int RepeatedStringMatch(string A, string B) {
        StringBuilder sb = new StringBuilder();
        int num = B.Length / A.Length;
        for(int i = 0; i < num; i++) sb.Append(A);
        if(sb.ToString().Contains(B)) return num;
        sb.Append(A);
        if(sb.ToString().Contains(B)) return num+1;
        sb.Append(A);
        if(sb.ToString().Contains(B)) return num+2;
        return -1;
    }
}
