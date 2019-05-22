//https://leetcode.com/problems/string-to-integer-atoi/

//Be care of overflow.

public class Solution {
    public int MyAtoi(string str) {
        str = str.Trim();
        if(str == "") return 0;
        int sign = 1;
        int cur = 0;
        if(str[0] == '-' || str[0] == '+') {
            if(str.Length < 2 || !isDigit(str[1])) return 0;
            if(str[0] == '-') sign = -1;
            cur = 1;
        } else {
            if(!isDigit(str[0])) return 0;
        }
        int head = cur;
        while(cur < str.Length && isDigit(str[cur])) cur += 1;
        string d = str.Substring(head, cur-head);
        int b = d[0] - '0';
        for(int i = 1; i < d.Length; i++){
            if(b > Int32.MaxValue/10 || b == Int32.MaxValue/10 && d[i] > '7'){
                System.Console.WriteLine(sign);
                if(sign == 1) return Int32.MaxValue;
                else return Int32.MinValue;
            }
            b = b*10+(d[i]-'0');
        }
        return b*sign;
    }
    
    private bool isDigit(char c) {
        return c >= '0' && c <= '9';
    }
}
