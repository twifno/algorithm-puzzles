//https://leetcode.com/problems/flatten-a-multilevel-doubly-linked-list/

//Recursion.

/*
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
    public Node child;

    public Node(){}
    public Node(int _val,Node _prev,Node _next,Node _child) {
        val = _val;
        prev = _prev;
        next = _next;
        child = _child;
}
*/
public class Solution {
    public Node Flatten(Node head) {
        return FlattenAndGetTail(head)[0];
    }
    
    private Node[] FlattenAndGetTail(Node head){
        Node[] res = new Node[2];
        res[0] = head;
        Node cur = head;
        Node tail = head;
        while(cur != null){
            tail = cur;
            if(cur.child != null){
                Node[] c = FlattenAndGetTail(cur.child);
                Node next = cur.next;
                cur.next = c[0];
                c[0].prev = cur;
                tail = c[1];
                c[1].next = next;
                if(next != null) next.prev = c[1];
                cur.child = null;
                cur = next;
            } else {
                cur = cur.next;
            }
        }
        res[1] = tail;
        return res;
    }
}
