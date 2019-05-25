//https://leetcode.com/problems/bulb-switcher/

//One square number will be one.

public class Solution {
    public int BulbSwitch(int n) {
        int count = 0;
        for(int i = 1; i <= n; i++) { 
            if(i * i > n) break;  
            count += 1;
        }
        return count;
    }
}
