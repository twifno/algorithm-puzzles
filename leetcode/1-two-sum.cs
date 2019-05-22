//https://leetcode.com/problems/two-sum/
//First try (O(n^2))

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        bool done=false;
        int[] ret = new int[2];
        for (int i=0; i < nums.Length-1; i++) {
            for(int j=i+1; j < nums.Length; j++){
                if(nums[i]+nums[j] == target){
                    ret[0] = i;
                    ret[1] = j;
                    done = true;
                    break;
                }
            }
            if (done == true) break;
        }
        return ret;
    }
}

//O(n) solution

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            int val = nums[i];
            if(dict.ContainsKey(target-val)){
                return new int[2] {dict[target-val], i};
            }
            dict[val] = i;
        }
        return null;
    }
    
}

