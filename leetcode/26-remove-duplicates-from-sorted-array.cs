//https://leetcode.com/problems/remove-duplicates-from-sorted-array/

//Squeeze to the front of the array

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int cur = 0;
        int head = 0;
        if(nums.Length == 0) return 0;
        while(cur < nums.Length-1){
            cur += 1;
            if(nums[cur] != nums[cur-1]){
                head += 1;
                nums[head] = nums[cur];
            }
        }
        return head + 1;
    }
}
