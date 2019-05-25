//https://leetcode.com/problems/paint-house-ii/

//Only need to save 2 lowest cost color

public class Solution {
    public int MinCostII(int[,] costs) {
        int l0 = costs.GetLength(0);
        if(l0 == 0) return 0;
        int l1 = costs.GetLength(1);
        int[] dp = new int[l1];
        for(int i = 0; i < l1; i++){
            dp[i] = costs[0, i];
        }
        for(int i = 1; i < l0; i++){
            int[] mins = GetMin(dp);
            int m1 = dp[mins[0]];
            int m2 = dp[mins[1]];
            for(int j = 0; j < l1; j++){
                if(j == mins[0] && l1 > 1) dp[j] = m2 + costs[i, j];
                else dp[j] = m1 + costs[i, j];
            }
        }
        int[] m = GetMin(dp);
        return dp[m[0]];
    }
    
    private int[] GetMin(int[] dp){
        int first = -1;
        int second = -1;
        int m1 = Int32.MaxValue;
        int m2 = Int32.MaxValue;
        for(int i = 0; i < dp.Length; i++){
            if(dp[i] < m1) {
                second = first;
                m2 = m1;
                first = i;
                m1 = dp[i];
            } else if(dp[i] < m2){
                second = i;
                m2 = dp[i];
            }
        }
        return new int[2]{first, second};
    }
}
