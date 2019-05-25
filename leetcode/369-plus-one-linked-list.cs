//https://leetcode.com/problems/plus-one-linked-list/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode PlusOne(ListNode head) {
        if(HasCarry(head)){
            ListNode node = new ListNode(1);
            node.next = head;
            return node;
        }
        return head;
    }
    
    private bool HasCarry(ListNode head) {
        if(head == null) return true;
        bool hasCarry = HasCarry(head.next);
        if(hasCarry){
            head.val += 1;
            if(head.val >= 10){
                head.val = 0;
                return true;
            }
        }
        return false;
    }
}
