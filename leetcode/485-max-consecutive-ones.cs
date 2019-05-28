//https://leetcode.com/problems/max-consecutive-ones/

public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int max = 0;
        int count = 0;
        foreach(int n in nums){
            if(n == 1) count += 1;
            else count = 0;
            max = Math.Max(max, count);
        }
        return max;
    }
}
