//https://leetcode.com/problems/single-number-ii/

public class Solution {
    public int SingleNumber(int[] nums) {
        int[] counts = new int[32];
        for(int i = 0; i < nums.Length; i++){
            for(int j = 0; j < 32; j++) {
                if(((uint)nums[i] & ((uint)1<<j)) != 0) counts[j] += 1;
            }
        }
        uint res = 0;
        for(int i = 0; i < 32; i++) {
            if(counts[i] % 3 != 0) res = res | ((uint)1<<i);
        }
        return (int)res;
    }
}
