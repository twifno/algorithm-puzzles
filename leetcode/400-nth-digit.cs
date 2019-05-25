//https://leetcode.com/problems/nth-digit/

//Be careful of overflow.

public class Solution {
    public int FindNthDigit(int n) {
        int dc = 1;
        int b = 9;
        int acc = 0;
        while(n > b*dc){
            n -= b*dc;
            dc += 1;
            acc += b;
            b *= 10;
            if(b * dc / dc != b) break;
        }
        acc += n/dc;
        System.Console.WriteLine(acc);
        System.Console.WriteLine(n);
        if(n % dc == 0) return acc % 10;
        acc += 1;
        int pos = n % dc;
        for(int i = 0; i < dc-pos; i++) acc/=10;
        return acc % 10;
    }
}
