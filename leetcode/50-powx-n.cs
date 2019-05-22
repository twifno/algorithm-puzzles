//https://leetcode.com/problems/powx-n/

//There is a faster iterative method…

public class Solution {
    Dictionary<int, double> cache = null;
    
    public double MyPow(double x, int n) {
        cache = new Dictionary<int, double>();
        cache[1] = x;
        cache[-1] = 1/x;
        cache[0] = 1;
        return P(x, n);
    }
    
    private double P(double x, int n){
        if(cache.ContainsKey(n)) return cache[n];
        double p = P(x, n/2) * P(x, n/2) * P(x, n%2);
        cache[n] = p;
        return p;
    }
}
