//https://leetcode.com/problems/insert-into-a-cyclic-sorted-list/

/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;

    public Node(){}
    public Node(int _val,Node _next) {
        val = _val;
        next = _next;
}
*/
public class Solution {
    public Node Insert(Node head, int insertVal) {
        if(head == null){
            head = new Node(insertVal, null);
            head.next = head;
            return head;
        }
        
        Node cur = head;
        while(cur.next != head){
            if(cur.val <= insertVal && cur.next.val >= insertVal) break;
            if(cur.val <= insertVal && cur.next.val < cur.val) break;
            if(cur.next.val < cur.val && cur.next.val > insertVal) break;
            cur = cur.next;
        }
        Node node = new Node(insertVal, cur.next);
        cur.next = node;
        return head;
    }
}
