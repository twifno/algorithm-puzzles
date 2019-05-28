//https://leetcode.com/problems/monotonic-array/

public class Solution {
    public bool IsMonotonic(int[] A) {
        bool inc = false;
        bool dec = false;
        for(int i = 1; i < A.Length; i++){
            if(A[i] > A[i-1]) {
                if(dec) return false;
                inc = true;
            } else if(A[i] < A[i-1]) {
                if(inc) return false;
                dec = true;
            }
        }
        return true;
    }
}
