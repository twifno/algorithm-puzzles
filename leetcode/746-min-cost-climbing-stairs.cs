//https://leetcode.com/problems/min-cost-climbing-stairs/

public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        if(cost.Length <= 1) return 0;
        for(int i = 2; i < cost.Length; i++){
            cost[i] = Math.Min(cost[i-1], cost[i-2]) + cost[i];
        }
        return Math.Min(cost[cost.Length-1], cost[cost.Length-2]);
    }
}
