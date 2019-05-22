//https://leetcode.com/problems/swap-nodes-in-pairs/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        return ReverseKGroup(head, 2);
    }
    
    public ListNode ReverseKGroup(ListNode head, int k) {
        int count = 0;
        ListNode cur = head;
        while(count < k && cur != null) {
            cur = cur.next;
            count += 1;
        }
        if(count < k) return head;
        cur = head;
        ListNode next = cur.next;
        for(int i = 1; i < k; i++){
            cur.next = next.next;
            next.next = head;
            head = next;
            next = cur.next;
        }
        cur.next = ReverseKGroup(next, k);
        return head;
    }
}
