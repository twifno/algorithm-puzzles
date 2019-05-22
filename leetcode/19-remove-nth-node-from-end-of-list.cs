//https://leetcode.com/problems/remove-nth-node-from-end-of-list/

//Pilot pointer technique

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode polit = head;
        for(int i = 0; i < n; i++) polit = polit.next;
        ListNode target = head;
        if(polit == null) return target.next;
        ListNode pre = null;
        while(polit != null){
            pre = target;
            polit = polit.next;
            target = target.next;
        }
        pre.next = target.next;
        return head;
    }
}
