//https://leetcode.com/problems/strobogrammatic-number-iii/

public class Solution {
    public int StrobogrammaticInRange(string low, string high) {
        int ll = low.Length;
        int hl = high.Length;
        int count = 0;
        if(ll == hl) {
            List<string> strobo = Strobo(ll, true);
            foreach(string s in strobo) if(s.CompareTo(low) >= 0 && s.CompareTo(high) <= 0) count += 1;
        } else {
            for(int i = ll; i <= hl; i++) {
                if(i == ll) {
                    List<string> strobo = Strobo(ll, true);
                    //foreach(string s in strobo) System.Console.WriteLine(s);
                    foreach(string s in strobo) if(s.CompareTo(low) >= 0) count += 1;
                } else if(i == hl){
                    List<string> strobo = Strobo(hl, true);
                    foreach(string s in strobo) if(s.CompareTo(high) <= 0) count += 1;
                } else count += StroboCount(i);
            }
        }
        return count;
    }
    
    private int StroboCount(int len){
        int mid = len / 2;
        int count = 1;
        for(int i = 0; i < mid-1; i++) count *= 5;
        count *= 4;
        if(len % 2 == 1) count *= 3;
        return count;
    }
    
    private List<string> Strobo(int len, bool final){
        string[] single = { "1", "8", "0" };
        string[,] pair = {{"6", "9"}, {"9", "6"}};
        if(len == 0) return new List<string>(new string[1] {""});
        if(len == 1) return new List<string>(single);            
        List<string> inner = Strobo(len-2, false);
        List<string> res = new List<string>();
        foreach(string s in inner){
            foreach(string c in single) {
                if(final && c == "0") continue;
                res.Add(c+s+c);
            }
            for(int i = 0; i < pair.GetLength(0); i++){
                res.Add(pair[i,0] + s + pair[i, 1]);
            }
        }
        return res;
    }
}
