//https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iii/

//My n^2 solution - not very good.

public class Solution {
    
    public int MaxProfit(int[] prices) {
        if(prices.Length == 0) return 0;
        int[] cache = new int[prices.Length];
        for(int i = 1; i < prices.Length; i++) cache[i] = MaxProfit(prices, 0, i+1);
        int p = cache[prices.Length-1];
        for(int i = 1; i < prices.Length; i++) p = Math.Max(p, cache[i-1]+MaxProfit(prices, i, prices.Length));
        return p;
    }
    
    public int MaxProfit(int[] prices, int left, int right) {
        int minPrice = Int32.MaxValue;
        int maxGain = 0;
        for(int i = left; i < right; i++){
            minPrice = Math.Min(minPrice, prices[i]);
            maxGain = Math.Max(maxGain, prices[i] - minPrice);
        }
        return maxGain;
    }
}
