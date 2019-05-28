//https://leetcode.com/problems/convert-binary-search-tree-to-sorted-doubly-linked-list/

/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;

    public Node(){}
    public Node(int _val,Node _left,Node _right) {
        val = _val;
        left = _left;
        right = _right;
}
*/
public class Solution {
    public Node TreeToDoublyList(Node root) {
        Node head = null;
        Node pre = null;
        Stack<Node> st = new Stack<Node>();
        PushLeft(st, root);
        while(st.Count > 0){
            Node n = st.Pop();
            PushLeft(st, n.right);
            if(pre == null){
                head = n;
                pre = n;
            } else {
                pre.right = n;
                n.left = pre;
                pre = n;
            }
        }
        if(pre != null){
            pre.right = head;
            head.left = pre;
        }
        return head;
    }
    
    private void PushLeft(Stack<Node> st, Node node){
        while(node != null){
            st.Push(node);
            node = node.left;
        }
    }
}
