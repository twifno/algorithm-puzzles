//https://leetcode.com/problems/shuffle-an-array/

public class Solution {
    
    int[] Nums;
    int[] Shuff;
    Random Rand;
    
    public Solution(int[] nums) {
        Nums = nums;
        Shuff = (int[])Nums.Clone();
        Rand = new Random();
    }
    
    /** Resets the array to its original configuration and return it. */
    public int[] Reset() {
        return (int[])Nums.Clone();
    }
    
    /** Returns a random shuffling of the array. */
    public int[] Shuffle() {
        for(int i = 0; i < Shuff.Length-1; i++){
            int next = Rand.Next(Shuff.Length-i);
            Swap(Shuff, i, i+next);
        }
        return (int[])Shuff.Clone();
    }
    
    private void Swap(int[] nums, int i, int j){
        int tmp = nums[i];
        nums[i] = nums[j];
        nums[j] = tmp;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */
