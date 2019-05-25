//https://leetcode.com/problems/missing-ranges/

//Be very careful on handling corner case
//Left = right + 1 > right can be 2^31-1
//Right - left  > 0 > left can be -2^31 and right can be 2^31-1

public class Solution {
    public IList<string> FindMissingRanges(int[] nums, int lower, int upper) {
        List<string> res = new List<string>();
        if(nums.Length == 0) {
            if(upper == lower) res.Add(upper.ToString());
            else res.Add(lower.ToString()+"->"+upper);
            return res;
        }
        int left = lower;
        int pos = 0;
        int right = nums[0];
        while(pos < nums.Length){
            if(right > left){
                if(right == left + 1) res.Add(left.ToString());
                else res.Add(left.ToString()+"->"+(right-1));
            }
            if(right < upper) left = right + 1;
            else return res;
            pos += 1;
            if(pos < nums.Length) right = nums[pos];
            else right = upper;
        }
        if(right >= left){
            if(right == left) res.Add(left.ToString());
            else res.Add(left.ToString()+"->"+(right));
        }
        return res;
    }
}

