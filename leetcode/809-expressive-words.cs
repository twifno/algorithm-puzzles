//https://leetcode.com/problems/expressive-words/

public class Solution {
    class Token {
        public int Max;
        public int Min;
        public char Val;
        public Token(int m, char v){
            Max = m;
            Val = v;
            Min = (Max >= 3)?1:Max;
        }
    }
    public int ExpressiveWords(string S, string[] words) {
        int cur = 0;
        List<Token> ts = new List<Token>();
        while(cur < S.Length){
            int head = cur;
            int tail = cur;
            while(tail < S.Length-1 && S[tail+1] == S[tail]) tail += 1;
            ts.Add(new Token(tail-head+1, S[head]));
            cur = tail + 1;
        }
        int count = 0;
        foreach(string w in words){
            cur = 0;
            int tn = 0;
            while(cur < w.Length){
                if(tn == ts.Count) {
                    tn += 1;
                    break;
                }
                int head = cur;
                int tail = cur;
                while(tail < w.Length-1 && w[tail+1] == w[tail]) tail += 1;
                Token token = ts[tn];
                if(token.Val != w[head] || token.Max < tail-head+1 || token.Min > tail-head+1) break;
                tn += 1;
                cur = tail + 1;
            }
            if(tn == ts.Count) count += 1;
        }
        return count;
    }
}
