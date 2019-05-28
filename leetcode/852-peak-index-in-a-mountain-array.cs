//https://leetcode.com/problems/peak-index-in-a-mountain-array/

public class Solution {
    public int PeakIndexInMountainArray(int[] A) {
        int left = 0;
        int right = A.Length-1;
        while(left <= right){
            int mid = left + (right - left)/2;
            if((mid == 0 || A[mid-1] < A[mid]) && (mid == A.Length-1 || A[mid] > A[mid+1])) return mid;
            if(mid == 0 || A[mid-1] < A[mid]) left = mid+1;
            else right = mid-1;
        }
        return left;
    }
}
