//https://leetcode.com/problems/first-missing-positive/

//Swap the number to the right position.

public class Solution {
    public int FirstMissingPositive(int[] nums) {
        if(nums.Length == 0) return 1;
        for(int i = 0; i < nums.Length; i++){
            int pos = i;
            while(true){
                if(pos == 0 && nums[0] == nums.Length) break;
                if(nums[pos] == pos) break;
                if(nums[pos] <= 0 || nums[pos] > nums.Length) {
                    nums[pos] = -1; 
                    break;
                }
                if(nums[pos] == nums.Length) {
                    if(nums[0] == nums.Length) nums[pos] = -1;
                    else {
                        int tmp = nums[0];
                        nums[0] = nums.Length;
                        nums[pos] = nums[0];
                    }
                }
                else if(nums[pos] == nums[nums[pos]]) nums[pos] = -1;
                else{
                    int tmp = nums[pos];
                    nums[pos] = nums[tmp];
                    nums[tmp] = tmp;
                } 
            }
        }
        for(int i = 1; i < nums.Length; i++){
            if(nums[i] == -1) return i;
        }
        if(nums[0] == nums.Length) return nums.Length + 1;
        return nums.Length;
    }
}
