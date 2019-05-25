//https://leetcode.com/problems/find-peak-element/

public class Solution {
    public int FindPeakElement(int[] nums) {
        int pos = 0;
        while(pos < nums.Length-1){
            if(nums[pos] > nums[pos+1]) return pos;
            pos += 1;
        }
        return nums.Length-1;
    }
}
