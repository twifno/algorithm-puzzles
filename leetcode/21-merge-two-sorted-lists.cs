//https://leetcode.com/problems/merge-two-sorted-lists/

//Stack approach

public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();
        foreach(char c in s){
            if(c == '(' || c == '{' || c == '[') st.Push(c);
            else {
                if(st.Count == 0) return false;
                char pre = st.Pop();
                if(c == ')' && pre != '(') return false;
                if(c == '}' && pre != '{') return false;
                if(c == ']' && pre != '[') return false;
            }
        }
        if(st.Count > 0) return false;
        return true;
    }
}
