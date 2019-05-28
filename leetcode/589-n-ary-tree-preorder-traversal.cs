//https://leetcode.com/problems/n-ary-tree-preorder-traversal/

//Remember to loop from the right child.

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
    public IList<int> Preorder(Node root) {
        List<int> res = new List<int>();
        if(root == null) return res;
        Stack<Node> st = new Stack<Node>();
        st.Push(root);
        while(st.Count > 0){
            Node node = st.Pop();
            res.Add(node.val);
            for(int i = node.children.Count-1; i >= 0; i--){
                st.Push(node.children[i]);
            }
        }
        return res;
    }
}
