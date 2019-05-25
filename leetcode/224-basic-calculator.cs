//https://leetcode.com/problems/basic-calculator/

public class Solution {
    public int Calculate(string s) {
        s = s.Replace(" ", "");
        return Calculate(s, 0, s.Length);
    }
    
    public int Calculate(string s, int start, int end) {
        int cur = start;
        int val = 0;
        while(cur < end){
            int[] res = Next(s, cur);
            val += res[0];
            cur = res[1];
        }
        return val;
    }
    
    private int[] Next(string s, int cur){
        bool neg = false;
        if(s[cur] == '-') {
            neg = true;
            cur += 1;
        } else if(s[cur] == '+') cur += 1;
        
        if(s[cur] == '(') {
            int pos = NextClose(s, cur);
            int val = Calculate(s, cur+1, pos);
            return new int[2] {neg?-val:val, pos+1};
        } else {
            int pos = NextNum(s, cur);
            int val = Int32.Parse(s.Substring(cur, pos-cur+1));
            return new int[2] {neg?-val:val, pos+1};
        }
    }
    
    private int NextClose(string s, int cur) {
        int count = 0;
        while(cur < s.Length){
            if(s[cur] == '(') count += 1;
            else if(s[cur] == ')') count -= 1;
            if(count == 0) return cur;
            cur += 1;
        }
        return cur;
    }
    
    private int NextNum(string s, int cur) {
        while(cur < s.Length && s[cur] >= '0' && s[cur] <= '9') cur += 1;
        return cur-1;
    }
}
