//https://leetcode.com/problems/rotate-list/

//Typical two pointer list operation.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        ListNode p1,p2;
        if(head == null) return null;
        p1 = head;
        for(int i = 0; i < k; i++){
            p1 = p1.next;
            if(p1 == null) {
                p1 = head;
                k = k%(i+1)+i+1;
            }
        }
        p2 = head;
        while(p1.next != null){
            p1 = p1.next;
            p2 = p2.next;
        }
        p1.next = head;
        head = p2.next;
        p2.next = null;
        return head;
    }
}
