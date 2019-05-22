//https://leetcode.com/problems/best-time-to-buy-and-sell-stock/

public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = Int32.MaxValue;
        int maxGain = 0;
        for(int i = 0; i < prices.Length; i++){
            minPrice = Math.Min(minPrice, prices[i]);
            maxGain = Math.Max(maxGain, prices[i] - minPrice);
        }
        return maxGain;
    }
}
