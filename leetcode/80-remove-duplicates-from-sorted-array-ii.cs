//https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length <= 2) return nums.Length;
        int count  = 1;
        int cur = 1;
        int tail = 0;
        while(cur < nums.Length){
            if(nums[cur] == nums[tail]){
                if(count < 2){
                    count += 1;
                    tail += 1;
                    nums[tail] = nums[cur];
                    cur += 1;
                } else {
                    cur += 1;
                }
            } else {
                count = 1;
                tail += 1;
                nums[tail] = nums[cur];
                cur += 1;
            }
        }
        return tail+1;
    }
}
