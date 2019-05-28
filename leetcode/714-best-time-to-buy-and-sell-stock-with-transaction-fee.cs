//https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-transaction-fee/

public class Solution {
    public int MaxProfit(int[] prices, int fee) {
        if(prices.Length == 0) return 0;
        int cash = 0;
        int hold = -prices[0];
        for(int i = 1; i < prices.Length; i++){
            cash = Math.Max(cash, hold + prices[i] - fee);
            hold = Math.Max(hold, cash - prices[i]);
        }
        return cash;
    }
}
