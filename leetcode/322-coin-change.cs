//https://leetcode.com/problems/coin-change/

public class Solution {
    Dictionary<int, int> Cache = new Dictionary<int, int>();
    public int CoinChange(int[] coins, int amount) {
        if(amount == 0) return 0;
        if(Cache.ContainsKey(amount)) return Cache[amount];
        int min = Int32.MaxValue;
        foreach(int coin in coins){
            if(amount >= coin){
                int change = CoinChange(coins, amount - coin);
                if(change != -1) min = Math.Min(min, change+1);
            }
        }
        if(min == Int32.MaxValue) {
            Cache[amount] = -1;
            return -1;
        }
        else {
            Cache[amount] = min;
            return min;
        }
    }
}
