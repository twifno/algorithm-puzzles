//https://leetcode.com/problems/contiguous-array/

public class Solution {
    public int FindMaxLength(int[] nums) {
        Stack<int> st0 = new Stack<int>();
        Stack<int> st1 = new Stack<int>();
        int max = 0;
        int[] maxes = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == 0) st0.Push(i);
            if(nums[i] == 1 && st0.Count > 0) {
                int pre = st0.Pop();
                maxes[i] = i-pre+1 + ((pre>0)?maxes[pre-1]:0);
            }
            if(nums[i] == 1) st1.Push(i);
            if(nums[i] == 0 && st1.Count > 0) {
                int pre = st1.Pop();
                maxes[i] = i-pre+1 + ((pre>0)?maxes[pre-1]:0);
            }
            max = Math.Max(max, maxes[i]);
        }
        return max;
    }
}
