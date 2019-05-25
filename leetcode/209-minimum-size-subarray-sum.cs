//https://leetcode.com/problems/minimum-size-subarray-sum/

public class Solution {
    public int MinSubArrayLen(int s, int[] nums) {
        if(nums.Length == 0) return 0;
        int left = 0;
        int right = 0;
        int sum = 0;
        int min = Int32.MaxValue;
        while(right < nums.Length){
            sum += nums[right];
            while(left < right && sum - nums[left] >= s) {
                sum -= nums[left];
                left += 1;
            }
            //System.Console.WriteLine(sum);
            if(sum >= s) min = Math.Min(min, right-left+1);
            right += 1;
        }
        if(min == Int32.MaxValue) return 0;
        return min;
    }
}
