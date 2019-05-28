//https://leetcode.com/problems/base-7/

public class Solution {
    public string ConvertToBase7(int num) {
        if(num < 0) return "-"+ConvertToBase7(-num);
        if(num/7== 0) return ""+num;
        return ConvertToBase7(num/7) + (num%7);
    }
}
