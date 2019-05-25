//https://leetcode.com/problems/valid-perfect-square/

//Binary search, be careful of number overflow!

public class Solution {
    public bool IsPerfectSquare(int num) {
        int left = 1;
        int right = num;
        while(left <= right){
            int mid = left + (right-left)/2;
            if(mid*mid/mid == mid && mid*mid == num) return true;
            else if (mid*mid/mid == mid && mid*mid < num) left = mid + 1;
            else right = mid-1;
        }
        return false;
    }
}
