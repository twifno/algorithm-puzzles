//https://leetcode.com/problems/k-th-symbol-in-grammar/

public class Solution {
    public int KthGrammar(int N, int K) {
        K -= 1;
        int count = 0;
        while(K != 0){
            count += (K & 1);
            K >>= 1;
        }
        if(count % 2 == 0) return 0;
        return 1;
    }
}
