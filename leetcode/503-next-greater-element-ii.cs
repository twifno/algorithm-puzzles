//https://leetcode.com/problems/next-greater-element-ii/

public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        Stack<int> st = new Stack<int>();
        int len = nums.Length;
        int[] greaters = new int[len];
        for(int i = 0; i < len; i++){
            while(st.Count > 0 && nums[st.Peek()] < nums[i]){
                greaters[st.Pop()] = nums[i];
            }
            st.Push(i);
        }
        for(int i = 0; i < len; i++){
            while(st.Count > 0 && nums[st.Peek()] < nums[i]){
                greaters[st.Pop()] = nums[i];
            }
        }
        while(st.Count > 0) greaters[st.Pop()] = -1;
        return greaters;
    }
}
