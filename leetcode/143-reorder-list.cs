//https://leetcode.com/problems/reorder-list/

//3 steps - cut, reverse and merge

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void ReorderList(ListNode head) {
        if(head == null) return;
        ListNode fast = head;
        ListNode slow = head;
        while(fast.next != null && fast.next.next != null){
            fast = fast.next.next;
            slow = slow.next;
        }
        ListNode second = slow.next;
        if(second == null) return;
        slow.next = null;
        //System.Console.WriteLine(second.val);
        second = Reverse(second);
        //ListNode tmp = second;
        //while(tmp != null) { System.Console.WriteLine(tmp.val); tmp = tmp.next; }
        ListNode first = head;
        while(first != null){
            ListNode next = first.next;
            first.next = second;
            if(second != null) { 
                second = second.next;
                first.next.next = next;
            }
            first = next;
        }
        return;
    }
    
    private ListNode Reverse(ListNode head){
        ListNode prev = null;
        while(head != null){
            ListNode next = head.next;
            head.next = prev;
            prev = head;
            head = next;
        }
        return prev;
    }
}
