//https://leetcode.com/problems/third-maximum-number/

public class Solution {
    public int ThirdMax(int[] nums) {
        int? max1 = null;
        int? max2 = null;
        int? max3 = null;
        foreach(int n in nums){
            if(max1 == null) max1 = n;
            else if(max1 < n) {
                max3 = max2;
                max2 = max1;
                max1 = n;
            } else if(max1 == n) continue;
            else if(max2 == null){
                max2 = n;
            } else if(max2 < n) {
                max3 = max2;
                max2 = n;
            } else if(max2 == n) continue;
            else if(max3 == null){
                max3 = n;
            } else if(max3 < n) {
                max3 = n;
            }
        }
        return (max3 == null)?(int)max1:(int)max3;
    }
}
