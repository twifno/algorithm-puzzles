//https://leetcode.com/problems/global-and-local-inversions/

public class Solution {
    public bool IsIdealPermutation(int[] A) {
        int len = A.Length;
        for(int i = 0; i < len-1; i++){
            if(A[i] > A[i+1]) {
                int tmp = A[i];
                A[i] = A[i+1];
                A[i+1] = tmp;
                i+=1;
            }
        }
        for(int i = 0; i < len-1; i++) if(A[i] > A[i+1]) return false;
        return true;
    }
}
