//https://leetcode.com/problems/random-pick-index/

public class Solution {

    Random Rand;
    int[] Nums;
    
    public Solution(int[] nums) {
        Nums = nums;
        Rand = new Random();
    }
    
    public int Pick(int target) {
        int count = 0;
        int res = -1;
        for(int i = 0; i < Nums.Length; i++){
            if(Nums[i] == target) {
                count +=1;
                if(Rand.Next(count) == 0) res = i;
            }
        }
        return res;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int param_1 = obj.Pick(target);
 */
