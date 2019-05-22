//https://leetcode.com/problems/partition-list/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode Partition(ListNode head, int x) {
        ListNode h1 = null;
        ListNode h2 = null;
        ListNode t1 = null;
        ListNode t2 = null;
        ListNode cur = head;
        while(cur != null){
            if(cur.val < x) {
                if(h1 == null) {
                    h1 = cur;
                    t1 = cur;
                } else {
                    t1.next = cur;
                    t1 = cur; 
                }
                cur = cur.next;
                t1.next = null;
            } else {
                if(h2 == null){
                    h2 = cur;
                    t2 = cur;
                } else {
                    t2.next = cur;
                    t2 = cur;  
                }
                cur = cur.next;
                t2.next = null;
            }
        }
        if(h1 == null) return h2;
        t1.next = h2;
        return h1;
    }
}
