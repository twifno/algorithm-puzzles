//https://leetcode.com/problems/total-hamming-distance/

public class Solution {
    public int TotalHammingDistance(int[] nums) {
        int[] bitCounts = new int[32];
        foreach(int n in nums){
            int pos = 0;
            int num = n;
            while(num != 0){
                if((num & 1) == 1) bitCounts[pos] += 1;
                pos += 1;
                num >>= 1;
            }
        }
        int len = nums.Length;
        int sum = 0;
        foreach(int n in bitCounts){
            sum += (len - n) * n;
        }
        return sum;
    }
}
