//https://leetcode.com/problems/4sum-ii/

public class Solution {
    public int FourSumCount(int[] A, int[] B, int[] C, int[] D) {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        int total = 0;
        for(int i = 0; i < A.Length; i++){
            for(int j = 0; j < B.Length; j++){
                int sum = A[i] + B[j];
                if(!counts.ContainsKey(sum)) counts[sum] = 1;
                else counts[sum] += 1;
            }
        }
        for(int i = 0; i < C.Length; i++){
            for(int j = 0; j < D.Length; j++){
                int sum = C[i] + D[j];
                if(counts.ContainsKey(-sum)) total += counts[-sum];
            }
        }
        return total;
    }
}
