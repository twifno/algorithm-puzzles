//https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode newNode = null;
        ListNode tail = null;
        ListNode cur = head;
        while(cur != null){
            if(cur.next != null && cur.val == cur.next.val){
                int val = cur.val;
                while(cur != null && cur.val == val) cur = cur.next;
            } else {
                if(newNode == null){
                    newNode = cur;
                    tail = cur;
                } else {
                    tail.next = cur;
                    tail = cur;
                }
                cur = cur.next;
                tail.next = null;
            }
        }
        return newNode;
    }
}
