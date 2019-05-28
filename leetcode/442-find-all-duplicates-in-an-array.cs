//https://leetcode.com/problems/find-all-duplicates-in-an-array/

//When asking for duplicate, 2 way to solve
//	1) Some bit manipulations
//	2) Move the number to the right index

public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        List<int> res = new List<int>();
        for(int i = 0; i < nums.Length; i++){
            while(nums[i] != -1 && nums[i] != i+1){
                int val = nums[i];
                if(val == nums[val-1]) {
                    res.Add(val);
                    nums[i] = -1;
                } else {
                    Swap(i, val-1, nums);
                }
            }
        }
        return res;
    }
    
    private void Swap(int i, int j, int[] nums){
        int tmp = nums[i];
        nums[i] = nums[j];
        nums[j] = tmp;
    }
}
