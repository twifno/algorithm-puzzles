//https://leetcode.com/problems/add-two-numbers/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode head = null;
        ListNode cur = null;
        int carry = 0;
        while (l1 != null || l2 != null){
            int sum = carry;
            if (l1 != null) {
                sum += l1.val;
                l1 = l1.next;
            }
            if (l2 != null) {
                sum += l2.val;
                l2 = l2.next;
            }
            carry = sum/10;
            ListNode newNode = new ListNode(sum % 10);
            if(head == null){
                head = newNode;
                cur = head;
            }else{
                cur.next = newNode;
                cur = cur.next;
            }
        }
        if (carry > 0){
            cur.next = new ListNode(carry);
        }
        return head;
    }
}
