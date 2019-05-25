//https://leetcode.com/problems/decode-string/

public class Solution {
    public string DecodeString(string s) {
        int cur = 0;
        StringBuilder sb = new StringBuilder();
        while(cur < s.Length) {
            if(IsDigit(s[cur])) {
                string tmp = NextInt(s, cur);
                cur += tmp.Length;
                int num = Int32.Parse(tmp);
                string token = NextToken(s, cur);
                cur += token.Length+2;
                string sub = DecodeString(token);
                for(int i = 0; i < num; i++) sb.Append(sub);
            } else {
                sb.Append(s[cur]);
                cur += 1;
            }
        }
        return sb.ToString();
    }
    
    private string NextInt(string s, int cur) {
        int head = cur;
        int tail = cur;
        while(tail < s.Length-1 && IsDigit(s[tail+1])) tail += 1;
        return s.Substring(head, tail-head+1);
    }
    
    private bool IsDigit(char c) {
        return c >= '0' && c <= '9';
    }
    
    private string NextToken(string s, int cur) {
        int head = cur;
        int count = 1;
        while(count > 0) {
            cur += 1;
            if(s[cur] == '[') count += 1;
            else if(s[cur] == ']') count -= 1;
        }
        return s.Substring(head+1, cur-head-1);
    }
}
