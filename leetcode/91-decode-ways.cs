//https://leetcode.com/problems/decode-ways/

//First try - back tracking…

public class Solution {
    Dictionary<string, int> cache;
    
    public int NumDecodings(string s) {
        cache = new Dictionary<string, int>();
        return Decode(s);
    }
    
    private int Decode(string s){
        if(cache.ContainsKey(s)) return cache[s]; 
        if(s.Length == 0) return 1;
        if(s[0] == '0') return 0;
        int sum = 0;
        for(int i = 1; i <= 2 && i <= s.Length; i++){
            string next = s.Substring(0, i);
            int n = Int32.Parse(next);
            if(n >= 1 && n <= 26) sum += Decode(s.Substring(i, s.Length-i));
        }
        cache[s] = sum;
        return sum;
    }
}

//DP

public class Solution {
    public int NumDecodings(string s) {
        if(s.Length == 0) return 0;
        if(s[0] == '0') return 0;
        int[] dp = new int[s.Length+1];
        dp[0] = 1;
        dp[1] = 1;
        for(int i = 2; i <= s.Length; i++){
            int sum = 0;
            string next = s.Substring(i-1, 1);
            if(next != "0") sum += dp[i-1];
            next = s.Substring(i-2, 2);
            if(next[0] != '0') {
                int n = Int32.Parse(next);
                if(n <= 26) sum += dp[i-2];
            }
            dp[i] = sum;
        }
        return dp[s.Length];
    }
}

