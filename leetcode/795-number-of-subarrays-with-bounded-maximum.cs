//https://leetcode.com/problems/number-of-subarrays-with-bounded-maximum/

public class Solution {
    public int NumSubarrayBoundedMax(int[] A, int L, int R) {
        int lastIn = -1;
        int lastOut = -1;
        int sum = 0;
        for(int i = 0; i < A.Length; i++){
            if(A[i] >= L) lastIn = i;
            if(A[i] > R) lastOut = i;
            sum += lastIn - lastOut;
        }
        return sum;
    }
}
