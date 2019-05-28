//https://leetcode.com/problems/1-bit-and-2-bit-characters/

//Find the second last 0, because 0 must separate two characters

public class Solution {
    public bool IsOneBitCharacter(int[] bits) {
        int len = bits.Length;
        if(bits[len-1] == 1) return false;
        int cur = len-2;
        while(cur >= 0 && bits[cur] == 1) cur -= 1;
        if((len-2-cur) % 2 == 0) return true;
        return false;
    }
}
