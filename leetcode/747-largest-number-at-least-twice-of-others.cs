//https://leetcode.com/problems/largest-number-at-least-twice-of-others/

public class Solution {
    public int DominantIndex(int[] nums) {
        if(nums.Length <= 1) return 0;
        int first = Int32.MinValue;
        int second = Int32.MinValue;
        int pos = -1;
        for(int i = 0; i < nums.Length; i++){
            int val = nums[i];
            if(val >= first){
                second = first;
                first = val;
                pos = i;
            } else if(val > second) {
                second = val;
            }
        }
        if(second * 2 <= first) return pos;
        return -1;
    }
}
