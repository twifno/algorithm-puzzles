//https://leetcode.com/problems/reach-a-number/

//1+2+… + k >= target && (1+2+…k - target)%2 == 0
Not Easy

public class Solution {
    public int ReachNumber(int target) {
        int sum = 0;
        int start = 1;
        if(target < 0) target = - target;
        while(true){
            sum += start;
            if(sum >= target && (sum-target) % 2 == 0) return start;
            start += 1;
        }
        return -1;
    }
}
