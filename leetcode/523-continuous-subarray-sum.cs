//https://leetcode.com/problems/continuous-subarray-sum/

//Pay attention to the corner cases
//1, two continues 0 value
//2, k = 0
//3, at least two element


public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        if(ContZero(nums)) return true;
        if(k == 0) return false;
        Dictionary<int, int> rems = new Dictionary<int, int>();
        rems[0] = -1;
        int sum = 0;
        for(int i = 0; i < nums.Length; i++){
            int n = nums[i];
            sum += n;
            int rem = sum % k;
            if(rems.ContainsKey(rem)) {
                if (i - rems[rem] >= 2) return true;
            } else {
                rems[rem] = i;
            }
        }
        return false;
    }
    
    private bool ContZero(int[] nums){
        for(int i = 0; i < nums.Length-1; i++){
            if(nums[i] == 0 && nums[i+1] == 0) return true;
        }
        return false;
    }
}
