//https://leetcode.com/problems/max-consecutive-ones-ii/

public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int max = 0;
        int count = 0;
        int pos = -1;
        for(int i = 0; i < nums.Length; i++){
            int n = nums[i];
            if(n == 1) count += 1;
            else {
                if(pos >= i - count) {
                    count = i - pos;
                } else {
                    count += 1;
                }
                pos = i;
            }
            max = Math.Max(max, count);
        }
        return max;
    }
}
