//https://leetcode.com/problems/2-keys-keyboard/

public class Solution {
    public int MinSteps(int n) {
        int sum = 0;
        for(int i = 2; i <= n; i++){
            while(n % i == 0){
                n = n/i;
                sum += i;
            }
        }
        return sum;
    }
}
