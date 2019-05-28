//https://leetcode.com/problems/solve-the-equation/

public class Solution {
    public string SolveEquation(string equation) {
        string[] sides = equation.Split('=');
        int[] left = Decode(sides[0]);
        int[] right = Decode(sides[1]);
        int[] final = new int[2] { left[0] - right[0], left[1] - right[1] };
        if(final[0] == 0 && final[1] == 0) return "Infinite solutions";
        if(final[0] == 0) return "No solution";
        return "x=" + (-final[1]/final[0]);
    }
    
    private int[] Decode(string s){
        int a = 0;
        int b = 0;
        int pos = 0;
        bool sign = true;
        if(s[0] == '-') {
            sign = false;
            pos += 1;
        }
        while(pos < s.Length) {
            int minus = s.IndexOf('-', pos);
            int plus = s.IndexOf('+', pos);
            int[] token;
            if(minus == -1 && plus == -1){
                token = DecodeToken(s.Substring(pos, s.Length-pos));
                if(!sign) { token[0] = -token[0]; token[1] = -token[1]; }
                pos = s.Length;
            } else if(minus == -1) {
                token = DecodeToken(s.Substring(pos, plus-pos));
                if(!sign) { token[0] = -token[0]; token[1] = -token[1]; }
                sign = true;
                pos = plus+1;
            } else if(plus == -1) {
                token = DecodeToken(s.Substring(pos, minus-pos));
                if(!sign) { token[0] = -token[0]; token[1] = -token[1]; }
                sign = false;
                pos = minus+1;
            } else if(plus < minus){
                token = DecodeToken(s.Substring(pos, plus-pos));
                if(!sign) { token[0] = -token[0]; token[1] = -token[1]; }
                sign = true;
                pos = plus+1;
            } else {
                token = DecodeToken(s.Substring(pos, minus-pos));
                if(!sign) { token[0] = -token[0]; token[1] = -token[1]; }
                sign = false;
                pos = minus+1;
            }
            //System.Console.WriteLine(token[0]);
            //System.Console.WriteLine(token[1]);
            a += token[0];
            b += token[1];
        }
        return new int[2]{a, b};
    }
    
    private int[] DecodeToken(string s){
        if(s == "x") return new int[2] {1, 0};
        int pos =  s.IndexOf('x');
        //System.Console.WriteLine(s);
        if(pos == -1) return new int[2] {0, Int32.Parse(s)};
        return new int[2] { Int32.Parse(s.Substring(0, pos)), 0};
    }
}
