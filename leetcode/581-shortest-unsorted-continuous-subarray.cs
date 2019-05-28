//https://leetcode.com/problems/shortest-unsorted-continuous-subarray/

public class Solution {
    public int FindUnsortedSubarray(int[] nums) {
        int left = nums.Length;
        int right = 0;
        Stack<int> st = new Stack<int>();
        st.Push(0);
        for(int i = 1; i < nums.Length; i++){
            if(nums[i] >= nums[st.Peek()]) {
                st.Push(i);
            } else {
                int max = st.Peek();
                while(st.Count > 0 && nums[i] < nums[st.Peek()]){
                    int p = st.Pop();
                    left = Math.Min(left, p);
                    right = Math.Max(right, p);
                }
                left = Math.Min(left, i);
                right = Math.Max(right, i);
                st.Push(max);
            }
        }
        if(left > right) return 0;
        else return right - left + 1;
    }
}
