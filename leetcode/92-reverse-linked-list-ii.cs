//https://leetcode.com/problems/reverse-linked-list-ii/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseBetween(ListNode head, int m, int n) {
        if(n == m) return head;
        ListNode tail;
        if(m == 1) return Reverse(head, n-m+1, out tail);
        else {
            ListNode pre = head;
            for(int i = 1; i < m-1; i++){ pre = pre.next; }
            pre.next = Reverse(pre.next, n-m+1, out tail);
            return head;
        }
    }
    
    public ListNode Reverse(ListNode head, int len, out ListNode tail) {
        if(len <= 1) {
            tail = head;
            return head;
        } else {
            ListNode next = Reverse(head.next, len-1, out tail);
            head.next = tail.next;
            tail.next = head;
            tail = head;
            return next;
        }
    }
}
