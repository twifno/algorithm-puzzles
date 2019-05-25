//https://leetcode.com/problems/wiggle-subsequence/

//Greedy algorithm

public class Solution {
    public int WiggleMaxLength(int[] nums) {
        if(nums.Length <= 1) return nums.Length;
        int count = 1;
        bool up = false;
        int cur = 1;
        while(cur < nums.Length && nums[cur] == nums[cur-1]) cur += 1;
        if(cur == nums.Length) return count;
        if(nums[cur] > nums[cur-1]) up = true;
        count = 2;
        cur += 1;
        while(cur < nums.Length){
            //System.Console.WriteLine(up);
            if(up && nums[cur] >= nums[cur-1]) cur += 1;
            else if(!up && nums[cur] <= nums[cur-1]) cur += 1;
            else {
                up = !up;
                cur += 1;
                count += 1;
            }
        }
        return count;
    }
}
