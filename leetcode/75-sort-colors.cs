//https://leetcode.com/problems/sort-colors/

public class Solution {
    public void SortColors(int[] nums) {
        int left = 0;
        while(left < nums.Length && nums[left] == 0) left += 1;
        int right = nums.Length-1;
        while(right >= 0 && nums[right] == 2) right -= 1;
        int cur = 0;
        while(cur < nums.Length && cur <= right){
            if(cur < left) cur += 1;
            else if(nums[cur] == 0){
                int tmp = nums[cur];
                nums[cur] = nums[left];
                nums[left] = tmp;
                left += 1;
            } else if (nums[cur] == 2){
                int tmp = nums[cur];
                nums[cur] = nums[right];
                nums[right] = tmp;
                right -= 1;
            } else cur += 1;
        }
    }
}
