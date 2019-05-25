//https://leetcode.com/problems/super-pow/

//a^b mod 1337 = (a mod 1337) ^ b mod 1337
//a^b = a^(b/10)^10

public class Solution {
    Dictionary<string, int> Cache = new Dictionary<string, int>();
    public int SuperPow(int a, int[] b) {
        int res = 1;
        for(int i = 0; i < b.Length; i++){
            res = Pow(res, 10) * Pow(a % 1337, b[i]) % 1337;
        }
        return res;
    }
    
    private int Pow(int a, int b){
        if(b == 0) return 1;
        if(b == 1) return a;
        return Pow(a, b/2) * Pow(a, b-b/2) % 1337;
    }
}
