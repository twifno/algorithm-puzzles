//https://leetcode.com/problems/arithmetic-slices/

public class Solution {
    public int NumberOfArithmeticSlices(int[] A) {
        if(A.Length <= 2) return 0;
        int start = 0;
        int cur = 2;
        int end = 0;
        int count = 0;
        while(cur < A.Length){
            if(A[cur] - A[cur-1] == A[cur-1] - A[cur-2]){
                end = cur;
            }else{
                if(end - start >= 2){
                    count += Count(end-start+1);
                }
                start = cur - 1;
                end = start;
            }
            cur += 1;
        }
        if(end - start >= 2){
            count += Count(end-start+1);
        }
        return count;
    }
    
    private int Count(int n){
        return (n-1)*(n-2)/2;
    }
}
