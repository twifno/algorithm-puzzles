//https://leetcode.com/problems/populating-next-right-pointers-in-each-node-ii/

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
        Node nextHead = null;
        Node prev = null;
        Node cur = root;
        while(cur != null){
            while(cur != null){
                if(cur.left != null) {
                    if(nextHead == null) {
                        nextHead = cur.left;
                        prev = cur.left;
                    } else {
                        prev.next = cur.left;
                        prev = cur.left;
                    }
                }
                if(cur.right != null) {
                    if(nextHead == null) {
                        nextHead = cur.right;
                        prev = cur.right;
                    } else {
                        prev.next = cur.right;
                        prev = cur.right;
                    }
                }
                cur = cur.next;
            } 
            cur = nextHead;
            nextHead = null;
            prev = null;
        }
        return root;
    }
}

