//https://leetcode.com/problems/evaluate-reverse-polish-notation/

public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> st = new Stack<int>();
        foreach(string t in tokens){
            if(t == "+"){
                st.Push(st.Pop() + st.Pop());
            } else if(t == "*") {
                st.Push(st.Pop() * st.Pop());
            } else if(t == "-") {
                st.Push(-st.Pop() + st.Pop());
            } else if(t == "/") {
                int n1 = st.Pop();
                int n2 = st.Pop();
                st.Push(n2/n1);
            } else {
                st.Push(Int32.Parse(t));
            }
        }
        return st.Pop();
    }
}
