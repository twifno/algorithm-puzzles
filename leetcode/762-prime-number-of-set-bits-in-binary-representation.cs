//https://leetcode.com/problems/prime-number-of-set-bits-in-binary-representation/

public class Solution {
    public int CountPrimeSetBits(int L, int R) {
        HashSet<int> primes = new HashSet<int>(new int[] {2, 3, 5, 7, 11, 13, 17, 19, 23, 29});
        int count = 0;
        for(int i = L; i <= R; i++){
            if(primes.Contains(BitCount(i))) count += 1;
        }
        return count;
    }
    
    private int BitCount(int num){
        int count = 0;
        while(num != 0){
            count += (num & 1);
            num >>= 1;
        }
        return count;
    }
}
