//https://leetcode.com/problems/linked-list-cycle/

//Slow fast pointer approach

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        if(head == null) return false;
        ListNode p1 = head;
        ListNode p2 = head.next;    
        while(p1 != p2){  
            p1 = p1.next;
            if(p1 == null) return false;
            p2 = p2.next;
            if(p2 == null) return false;
            p2 = p2.next;
            if(p2 == null) return false;
        }
        return true;
    }
}
