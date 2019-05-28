//https://leetcode.com/problems/optimal-division/

public class Solution {
    public string OptimalDivision(int[] nums) {
        if(nums.Length == 1) return nums[0].ToString();
        StringBuilder sb = new StringBuilder();
        sb.Append(nums[0]);
        sb.Append("/");
        if(nums.Length > 2) sb.Append("(");
        for(int i = 1; i < nums.Length; i++){
            sb.Append(nums[i]);
            if(i != nums.Length-1) sb.Append("/");
        }
        if(nums.Length > 2) sb.Append(")");
        return sb.ToString();   
    }
}
