//https://leetcode.com/problems/preimage-size-of-factorial-zeroes-function/

public class Solution {
    public int PreimageSizeFZF(int K) {
        long left = K;
        long right = (long)K*5; //be careful!!!
        while(left <= right){
            long mid = left + (right-left)/2;
            //System.Console.WriteLine(mid);
            //System.Console.WriteLine(Zeros(mid));
            if(Zeros(mid) == K) return 5;
            else if(Zeros(mid) < K) left = mid+1;
            else right = mid-1;
        }
        return 0;
    }
    
    private int Zeros(long K) {
        long sum = 0;
        while(K != 0){
            sum += K/5;
            K = K/5;
        }
        return (int)sum;
    }
}
