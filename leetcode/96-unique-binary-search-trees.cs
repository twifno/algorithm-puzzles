//https://leetcode.com/problems/unique-binary-search-trees/

//Recursion with Cache.

public class Solution {
    Dictionary<string, int> cache;
    
    public int NumTrees(int n) {
        cache  = new Dictionary<string, int>();
        return Find(1, n);
    }
    private int Find(int left, int right){
        if(left >= right) return 1;
        string key = left.ToString()+"-"+right.ToString();
        if(cache.ContainsKey(key)) return cache[key];
        int sum = 0;
        for(int i = left; i <= right; i++){
            sum += Find(left, i-1) * Find(i+1, right);
        }
        cache[key] = sum;
        return sum;
    }
}

//This problem can be solved by simple DP or
//Math - Catalan numbers
