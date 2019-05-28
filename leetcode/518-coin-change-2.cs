//https://leetcode.com/problems/coin-change-2/

//Accumulate each coins.

public class Solution {
    public int Change(int amount, int[] coins) {
        int[] counts = new int[amount+1];
        counts[0] = 1;
        foreach(int c in coins){
            for(int i = 0; i < amount; i++){
                if(counts[i] > 0 && i+c <= amount) counts[i+c] += counts[i];
            }
        }
        return counts[amount];
    }
}
