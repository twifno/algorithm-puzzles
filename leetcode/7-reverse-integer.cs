//https://leetcode.com/problems/reverse-integer/

public class Solution {
    public int Reverse(int x) {
        int rev = 0;
        while(x != 0){
            if(rev == (rev * 10 + x % 10) / 10) { rev = rev*10 + x % 10; x /= 10;}
            else return 0;
        }
        return rev;
    }
}
