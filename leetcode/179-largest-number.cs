//https://leetcode.com/problems/largest-number/

//Sort by concatenate pairs 

public class Solution {
    public string LargestNumber(int[] nums) {
        Array.Sort(nums, (x, y) => (y.ToString()+x).CompareTo(x.ToString()+y));
        string num = string.Join("", nums);
        if(num[0] == '0') return "0";
        return num;
    }
}
