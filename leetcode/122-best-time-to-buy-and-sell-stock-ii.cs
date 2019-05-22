//https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/

public class Solution {
    public int MaxProfit(int[] prices) {
        int sum = 0;
        for(int i = 1; i < prices.Length; i++) sum += Math.Max(0, prices[i]-prices[i-1]);
        return sum;
    }
}
