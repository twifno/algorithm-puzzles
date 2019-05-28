//https://leetcode.com/problems/non-decreasing-array/

//Don’t actually need a stack, but the code looks simpler.

public class Solution {
    public bool CheckPossibility(int[] nums) {
        Stack<int> st = new Stack<int>();
        foreach(int n in nums){
            if(st.Count > 0 && st.Peek() > n){
                int val = st.Pop();
                if(st.Count == 0 || st.Peek() <= n) {
                    st.Push(n);
                } else {
                    st.Push(val);
                }
            } else {
                st.Push(n);
            }
        }
        return st.Count + 1 >= nums.Length;
    }
}
