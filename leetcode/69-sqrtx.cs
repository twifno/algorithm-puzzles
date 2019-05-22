//https://leetcode.com/problems/sqrtx/

//Binary Search
//Be careful with overflow..

public class Solution {
    public int MySqrt(int x) {
        int left = 0;
        int right = x/2;
        while(left <= right){
            int mid = left + (right-left)/2;
            double val = mid*1.0*mid;
            if(val <= x){
                if((mid+1)*1.0*(mid+1) > x) return mid;
                else left = mid+1;
            } else {
                right = mid-1;
            }
        }
        return left;
    }
}

//This can also be done by newton's method
//N = n - (n^2-x)/2n
