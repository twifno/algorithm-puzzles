//https://leetcode.com/problems/generate-parentheses/

//Back tracking - recursion

public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        List<string> cur = new List<string>();
        List<string> res = new List<string>();
        if(n == 0) return res;
        GenP(0, 0, cur, res, n);
        return res;
    }
    
    private void GenP(int l, int r, List<string> cur, IList<string> res, int n){
        if(l == r && l == n) {
            res.Add(string.Join("", cur));
            return;
        }
        if(l < n) {
            cur.Add("(");
            GenP(l+1, r, cur, res, n);
            cur.RemoveAt(cur.Count-1);
        }
        if(r < l) {
            cur.Add(")");
            GenP(l, r+1, cur, res, n);
            cur.RemoveAt(cur.Count-1);
        }
        return;
    }
}


//Iterative

public class Solution {
    class Node {
        internal int l = 0;
        internal int r = 0;
        internal string cur = "";
    }
    public IList<string> GenerateParenthesis(int n) {
        List<string> res = new List<string>();
        if(n == 0) return res;
        Stack<Node> st = new Stack<Node>();
        st.Push(new Node());
        while(st.Count > 0){
            Node node = st.Pop();
            if(node.l == node.r && node.l == n) {
                res.Add(node.cur);
            } else {
                if(node.l < n){
                    Node newNode = new Node();
                    newNode.l = node.l+1;
                    newNode.r = node.r;
                    newNode.cur = node.cur + "(";
                    st.Push(newNode);
                }
                if(node.r < node.l){
                    Node newNode = new Node();
                    newNode.l = node.l;
                    newNode.r = node.r + 1;
                    newNode.cur = node.cur + ")";
                    st.Push(newNode);
                }
            }
        }
        return res;
    }
}

