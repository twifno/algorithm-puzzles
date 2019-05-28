//https://leetcode.com/problems/set-mismatch/

public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int dup = 0;
        int miss = 0;
        int pos = 0;
        while(pos < nums.Length){
            if(nums[pos] == -1) { 
                miss = pos+1;
                pos += 1;
            }
            else if(nums[pos] == pos + 1) pos += 1;
            else if(nums[nums[pos]-1] == nums[pos]) {
                dup = nums[pos];
                nums[pos] = -1;
            }
            else Swap(nums, pos, nums[pos]-1);
        }
        return new int[2] { dup, miss };
    }
    
    private void Swap(int[] nums, int p1,  int p2){
        int tmp = nums[p1];
        nums[p1] = nums[p2];
        nums[p2] = tmp;
    }
}
