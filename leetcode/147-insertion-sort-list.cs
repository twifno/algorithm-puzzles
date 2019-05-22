//https://leetcode.com/problems/insertion-sort-list/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode InsertionSortList(ListNode head) {
        if(head == null) return null;
        ListNode cur = head.next;
        ListNode pre = head;
        while(cur != null){
            if(head.val >= cur.val){
                pre.next = cur.next;
                cur.next = head;
                head = cur;
                cur = pre.next;
            } else {
                ListNode tail = head;
                while(tail.next != cur && tail.next.val < cur.val){
                    tail = tail.next;
                }
                if(tail.next != cur){
                    pre.next = cur.next;
                    cur.next = tail.next;
                    tail.next = cur;
                    cur = pre.next;
                } else {
                    pre = pre.next;
                    cur = cur.next;
                }
            }
        }
        return head;
    }
}
