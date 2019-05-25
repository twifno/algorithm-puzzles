//https://leetcode.com/problems/factor-combinations/

//Back tracking..

public class Solution {
    List<int> factories;
    
    public IList<IList<int>> GetFactors(int n) {
        factories = new List<int>();
        for(int i = 2; i <= Math.Sqrt(n); i++){
            if(n%i == 0) {
                factories.Add(i);
                if(n/i != i) factories.Add(n/i);
            }
        }
        factories.Sort();
        return GetFactors(n, 0);
    }
    
    public IList<IList<int>> GetFactors(int n, int start){
        List<IList<int>> res = new List<IList<int>>();
        for(int i = start; i < factories.Count; i++){
            if(n%factories[i] == 0 && n != factories[i]) {
                IList<IList<int>> subRes = GetFactors(n/factories[i], i);
                foreach(IList<int> f in subRes){
                    f.Add(factories[i]);
                    res.Add(f);
                }
            } else if(n == factories[i]) {
                List<int> f = new List<int>();
                f.Add(n);
                res.Add(f);
            }
        }
        return res;
    }
}
