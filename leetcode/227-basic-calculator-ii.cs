//https://leetcode.com/problems/basic-calculator-ii/

public class Solution {
    public int Calculate(string s) {
        s = s.Replace(" ", "");
        if(s == "") return 0;
        int total = 0;
        int lastToken = 0;
        int cur = 0;
        if(s[0] != '-' && s[0] != '+') s = "+" + s;
        while(cur < s.Length) {
            string token = NextToken(s, cur);
            cur += token.Length;
            char sign = token[0];
            int num = Int32.Parse(token.Substring(1, token.Length-1));
            if(sign == '+'){
                total += num;
                lastToken = num;
            } else if(sign == '-') {
                total -= num;
                lastToken = -num;
            } else if(sign == '*') {
                total -= lastToken;
                lastToken *= num;
                total += lastToken;
            } else {
                total -= lastToken;
                lastToken /= num;
                total += lastToken;
            }
        }
        return total;
    }
    
    private string NextToken(string s, int cur) {
        int head = cur;
        int tail = cur+1;
        while(tail < s.Length-1 && IsDigit(s[tail+1])) tail += 1;
        return s.Substring(head, tail-head+1);
    }
    
    private bool IsDigit(char c) {
        return c >= '0' && c <= '9';
    }
}
