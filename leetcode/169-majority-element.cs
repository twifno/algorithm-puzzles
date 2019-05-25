//https://leetcode.com/problems/majority-element/

public class Solution {
    public int MajorityElement(int[] nums) {
        int maj = nums[0];
        int count = 1;
        for(int i = 1; i < nums.Length; i++){
            if(nums[i] == maj) count += 1;
            else {
                if(count == 0) {
                    maj = nums[i];
                    count = 1;
                } else count -= 1;
            }
        }
        return maj;
    }
}
