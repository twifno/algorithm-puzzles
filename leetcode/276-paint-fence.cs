//https://leetcode.com/problems/paint-fence/

//Cache[n] = (k-1) * (Ways(n-1, k) + Ways(n-2, k));

public class Solution {
    public int NumWays(int n, int k) {
        if(k == 0 || n == 0) return 0;
        if(k == 1){
            if(n <= 2) return 1;
            else return 0;
        }
        Cache = new Dictionary<int, int>();
        return Ways(n, k)/(k-1)*k;
    }
    
    Dictionary<int, int> Cache = null;
    
    public int Ways(int n, int k){
        if(n == 1) return k-1;
        if(n == 2) return k*(k-1);
        if(Cache.ContainsKey(n)) return Cache[n];
        Cache[n] = (k-1) * (Ways(n-1, k) + Ways(n-2, k));
        return Cache[n];
    }
}
