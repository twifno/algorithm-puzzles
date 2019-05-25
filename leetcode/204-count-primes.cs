//https://leetcode.com/problems/count-primes/

public class Solution {
    public int CountPrimes(int n) {
        bool[] notPrime = new bool[n];
        int count = 0;
        if(n <= 1) return 0;
        for(int i = 2; i < n; i++){
            if(notPrime[i]) continue;
            count += 1;
            int t = 2*i;
            while(t < n){
                notPrime[t] = true;
                t+=i;
            }
        }
        return count;
    }
}
