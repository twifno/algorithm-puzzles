//https://leetcode.com/problems/split-array-largest-sum/

//Binary Search

public class Solution {
    public int SplitArray(int[] nums, int m) {
        int sum = 0;
        int max = 0;
        foreach(int n in nums) {
            sum += n;
            max = Math.Max(n, max);
        }
        if(m == 1) return sum;
        int left = max;
        int right = sum;
        while(left <= right){
            int mid = left + (right-left)/2;
            if(CanSplit(nums, m, mid)) right = mid - 1;
            else left = mid + 1;
        }
        if(CanSplit(nums, m, left)) return left;
        return left+1;
    }
    
    private bool CanSplit(int[] nums, int m, int max){
        int sum = 0;
        int cur = 0;
        while(cur < nums.Length){
            if(nums[cur] > max) return false;
            sum += nums[cur];
            if(sum > max) {
                m -= 1;
                sum = nums[cur];
                if(m == 0) return false;
            }
            cur += 1;
        }
        return true;
    }
}
