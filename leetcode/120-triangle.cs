//https://leetcode.com/problems/triangle/

//Using Cache

public class Solution {
    Dictionary<string, int> cache = new Dictionary<string, int>();
    
    public int MinimumTotal(IList<IList<int>> triangle) {
        return Find(triangle, 0, 0);
    }
    
    private int Find(IList<IList<int>> triangle, int pos, int layer){
        if(layer >= triangle.Count) {
            return 0;
        }
        string key = pos.ToString()+" "+layer;
        if(cache.ContainsKey(key)) return cache[key];
        int sum = triangle[layer][pos];
        sum += Math.Min(Find(triangle, pos, layer+1)
                        , Find(triangle, pos+1, layer+1));
        cache[key] = sum;
        return sum;
    }
}


//Bottom up using DP

public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        int[] dp = new int[triangle.Count];
        for(int i = 0; i < dp.Length; i++){
            dp[i] = triangle[triangle.Count-1][i];
        }
        for(int i = triangle.Count-2; i >= 0; i--){
            for(int j = 0; j <= i; j++){
                dp[j] = Math.Min(dp[j], dp[j+1]) + triangle[i][j];
            }
        }
        return dp[0];
    }
}

