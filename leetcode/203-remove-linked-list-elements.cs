//https://leetcode.com/problems/remove-linked-list-elements/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        while(head != null && head.val == val) head = head.next;
        if(head == null) return head;
        ListNode p = head;
        while(p.next != null){
            if(p.next.val == val) p.next = p.next.next;
            else p = p.next;
        }
        return head;
    }
}
