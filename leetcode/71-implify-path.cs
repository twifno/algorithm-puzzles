//https://leetcode.com/problems/simplify-path/

//Stack..
//Be careful to the corner case.

public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> st = new Stack<string>();
        while(path.Length > 0){
            int i = path.IndexOf('/');
            if(i == -1){
                string token = path;
                path = "";
                if(token == "..") {if(st.Count > 0) st.Pop();}
                else if(token == ".") continue;
                else st.Push(token);
            } else if (i == 0){
                path = path.Substring(1, path.Length-1);
            } else {
                string token = path.Substring(0, i);
                path = path.Substring(i+1, path.Length-i-1);
                if(token == "..") {if(st.Count > 0) st.Pop();}
                else if(token == ".") continue;
                else st.Push(token);
            }
        }
        if(st.Count == 0) return "/";
        StringBuilder sb = new StringBuilder();
        while(st.Count > 0){
            string token = st.Pop();
            sb.Insert(0, token);
            sb.Insert(0, '/');
        }
        return sb.ToString();
    }
}
