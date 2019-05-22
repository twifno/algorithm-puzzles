//https://leetcode.com/problems/largest-rectangle-in-histogram/

//Stack trick..

public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int len = heights.Length;
        if(len == 0) return 0;
        int max = 0;
        Stack<int> st = new Stack<int>();
        st.Push(-1);
        for(int i = 0; i < len; i++){
            while(st.Count > 1 && heights[st.Peek()] > heights[i]){
                int pos = st.Pop();
                max = Math.Max(max, (i-st.Peek()-1) * heights[pos]);
            }
            st.Push(i);
        }
        while(st.Count > 1){
            int pos = st.Pop();
            max = Math.Max(max, (len-st.Peek()-1) * heights[pos]);
        }
        return max;
    }
}
