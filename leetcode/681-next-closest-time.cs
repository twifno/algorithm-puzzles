//https://leetcode.com/problems/next-closest-time/

//Bit by bit approach.

public class Solution {
    public string NextClosestTime(string time) {
        char[] digits = {time[0], time[1], time[3], time[4]};
        char[] res = time.ToCharArray();
        Array.Sort(digits);
        for(int i = 4; i >= 0; i--) {
            char limit;
            if(i == 4) limit = '9';
            else if(i == 3) limit = '5';
            else if(i == 2) continue;
            else if(i == 1) {
                if(res[0] < '2') limit = '9';
                else limit = '3';
            } else {
                limit = '2';
            }
            char cur = res[i];
            char next = Update(cur, limit, digits);
            res[i] = next;
            if(next > cur) return new string(res);
        }
        return new string(res);
    }
    
    private char Update(char cur, char limit, char[] digits){
        if(cur == limit) return digits[0];
        int pos = 0;
        while(pos < 4 && digits[pos] <= cur ) pos += 1;
        if(pos == 4 || digits[pos] > limit) return digits[0];
        return digits[pos];
    }
}
