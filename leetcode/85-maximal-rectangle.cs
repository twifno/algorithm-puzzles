//https://leetcode.com/problems/maximal-rectangle/

public class Solution {
    public int MaximalRectangle(char[,] matrix) {
        int l0 = matrix.GetLength(0);
        int l1 = matrix.GetLength(1);
        int[] hg = new int[l1];
        int max = 0;
        for(int i = 0; i < l0; i++){
            for(int j = 0; j < l1; j++){
                if(matrix[i,j] == '0') hg[j] = 0;
                else hg[j] += 1;
            }
            max = Math.Max(max, MaxRect(hg));
        }
        return max;
    }
    
    private int MaxRect(int[] hg){
        if(hg.Length == 0) return 0;
        Stack<int> st = new Stack<int>();
        st.Push(-1);
        int max = 0;
        for(int i = 0; i < hg.Length; i++){
            while(st.Peek() != -1 && hg[st.Peek()] > hg[i]){
                int pos = st.Pop();
                max = Math.Max(max, (i - st.Peek() - 1) * hg[pos]);
            }
            st.Push(i);
        }
        while(st.Peek() != -1){
            int pos = st.Pop();
            max = Math.Max(max, (hg.Length - st.Peek() - 1) * hg[pos]);
        }
        return max;
    }
}
