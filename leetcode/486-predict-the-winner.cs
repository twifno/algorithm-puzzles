//https://leetcode.com/problems/predict-the-winner/

//DP

public class Solution {
    public bool PredictTheWinner(int[] nums) {
        int len = nums.Length;
        int[] sums = new int[nums.Length];
        int sum = 0;
        for(int i = 0; i < nums.Length; i++) {
            sum += nums[i];
            sums[i] = sum;
        }
        int[] dp = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++){
            dp[i] = nums[i];
        }
        for(int i = 1; i < nums.Length; i++){
            //System.Console.WriteLine(string.Join(" ", dp));
            for(int j = 0; j < nums.Length-i; j++){
                int next = sums[j+i] - sums[j] - dp[j+1] + nums[j];
                if(j == 0) next = Math.Max(sums[j+i-1] - dp[j] + nums[j+i], next);
                else next = Math.Max(sums[j+i-1] - sums[j-1] - dp[j] + nums[j+i], next);
                dp[j] = next;
            }
        }
        if(sum - dp[0] <= dp[0]) return true;
        return false;
    }
}
