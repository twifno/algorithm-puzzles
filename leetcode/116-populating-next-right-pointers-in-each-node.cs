//https://leetcode.com/problems/populating-next-right-pointers-in-each-node/

/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node(){}
    public Node(int _val,Node _left,Node _right,Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
}
*/
public class Solution {
    public Node Connect(Node root) {
        if(root == null) return null;
        Node prev = null;
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(root);
        q.Enqueue(null);
        while(q.Count > 0){
            Node cur = q.Dequeue();
            if(prev != null) prev.next = cur;
            prev = cur;
            if(cur == null){
                if(q.Count > 0) q.Enqueue(null);
            } else {
                if(cur.left != null) q.Enqueue(cur.left);
                if(cur.right != null) q.Enqueue(cur.right);
            }
        }
        return root;
    }
}
