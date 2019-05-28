//https://leetcode.com/problems/backspace-string-compare/

public class Solution {
    public bool BackspaceCompare(string S, string T) {
        Stack<char> st = new Stack<char>();
        foreach(char c in S){
            if(c == '#') {
                if(st.Count > 0) st.Pop();
            } else {
                st.Push(c);
            }
        }
        string s = new string(st.ToArray());
        st.Clear();
        foreach(char c in T){
            if(c == '#') {
                if(st.Count > 0) st.Pop();
            } else {
                st.Push(c);
            }
        }
        string t = new string(st.ToArray());
        return s == t;
    }
}
