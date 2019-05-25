//https://leetcode.com/problems/reverse-linked-list/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if(head == null) return head;
        else if(head.next == null) return head;
        ListNode newNode = ReverseList(head.next);
        head.next.next = head;
        head.next = null;
        return newNode;
    }
}
