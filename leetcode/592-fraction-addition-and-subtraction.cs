//https://leetcode.com/problems/fraction-addition-and-subtraction/

/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node(){}
    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
}
*/
public class Solution {
    public IList<int> Postorder(Node root) {
        List<int> res = new List<int>();
        if(root == null) return res;
        Stack<Node> st = new Stack<Node>();
        st.Push(root);
        while(st.Count > 0){
            Node node = st.Pop();
            res.Add(node.val);
            foreach(Node n in node.children){
                st.Push(n);
            }
        }
        res.Reverse();
        return res;
    }
}
