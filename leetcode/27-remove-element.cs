//https://leetcode.com/problems/remove-element/

//Replace target element with number on the tail.

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int newLen = nums.Length;
        for(int i = nums.Length-1; i >= 0; i--){
            if(val == nums[i]){
                nums[i] = nums[newLen-1];
                newLen -= 1;
            }
        }
        return newLen;
    }
}
