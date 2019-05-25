//https://leetcode.com/problems/integer-replacement/

public class Solution {
    public int IntegerReplacement(int n) {
        int count = 0;
        if(n == Int32.MaxValue) return 32;
        while(n != 1){
            if(n % 2 == 0) n /= 2;
            else if(n <= 3) n -= 1;
            else if((n & 3) == 3) n += 1;
            else n -= 1;
            count += 1;
        }
        return count;
    }
}
