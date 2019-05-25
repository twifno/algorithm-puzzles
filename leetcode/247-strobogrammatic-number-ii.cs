//https://leetcode.com/problems/strobogrammatic-number-ii/

public class Solution {
    string[] cases = {"11","00","88","69","96"};
    
    public IList<string> FindStrobogrammatic(int n) {
        List<string> res = PesudoStrbo(n);
        if(n > 1){
            for(int i = res.Count-1; i >= 0; i--){
                if(res[i][0] == '0') res.RemoveAt(i);
            }
        }
        return res;
    }
    
    private List<string> PesudoStrbo(int n){
        List<string> res = new List<string>();
        if(n == 1) return new List<string> {"1", "0", "8"};
        else if(n == 2) return new List<string>{"11","00","88","69","96"};
        else if(n <= 0) return res;
        IList<string> inners = PesudoStrbo(n-2);
        foreach(string c in cases){
            foreach(string inn in inners){
                res.Add(c[0].ToString()+inn+c[1]);
            }
        }
        return res;
    }
}
