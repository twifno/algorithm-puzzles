//https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/

//Trick is to mark visited element in place.

public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        for(int i = 0; i < nums.Length; i++){
            int val = nums[i];
            if(val < 0) val = -val;
            if(nums[val-1] > 0) nums[val-1] = -nums[val-1];
        }
        List<int> res = new List<int>();
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] > 0) res.Add(i+1);
        }
        return res;
    }
}
