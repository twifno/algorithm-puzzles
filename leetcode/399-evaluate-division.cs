//https://leetcode.com/problems/evaluate-division/

//Floyd-Warshall 

public class Solution {
    class Equation {
        public string A;
        public string B;
        public string Express;
        public override bool Equals(object obj){
            return Express.Equals(((Equation)obj).Express);
        }
        public override int GetHashCode() {
            return Express.GetHashCode();
        }
        
        public Equation(string a, string b) {
            A = a;
            B = b;
            Express = a + "/" + b;
        }
    }
    
    public double[] CalcEquation(string[][] equations, double[] values, string[][] queries) {
        Dictionary<Equation, double> g = new Dictionary<Equation, double>();
        HashSet<string> ends = new HashSet<string>();
        for(int i = 0; i < values.Length; i++){
            g[new Equation(equations[i][0], equations[i][1])] = values[i];
            g[new Equation(equations[i][1], equations[i][0])] = 1/values[i];
            g[new Equation(equations[i][0], equations[i][0])] = 1;
            g[new Equation(equations[i][1], equations[i][1])] = 1;
            ends.Add(equations[i][1]);
            ends.Add(equations[i][0]);
        }
        foreach(string e in ends){
            foreach(string s in ends) {
                foreach(string t in ends){
                    Equation se = new Equation(s, e);
                    Equation et = new Equation(e, t);
                    if(g.ContainsKey(se) && g.ContainsKey(et)) {
                        g[new Equation(s, t)] = g[se] * g[et];
                        g[new Equation(t, s)] = 1/(g[se] * g[et]);
                    }
                }
            }
        }
        int len = queries.GetLength(0);
        double[] res = new double[len];
        for(int i = 0; i < len; i++){
            Equation eq = new Equation(queries[i][0], queries[i][1]);
            if(g.ContainsKey(eq)) res[i] = g[eq];
            else res[i] = -1;
        }
        return res;
    }
}
