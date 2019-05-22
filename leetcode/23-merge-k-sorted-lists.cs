//https://leetcode.com/problems/merge-k-sorted-lists/

//Round robin to merge lists two by two.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists.Length == 0) return null;
        Queue<ListNode> q = new Queue<ListNode>();
        foreach(ListNode list in lists) q.Enqueue(list);
        while(q.Count > 1){
            ListNode l1 = q.Dequeue();
            ListNode l2 = q.Dequeue();
            ListNode l = MergeTwoLists(l1, l2);
            q.Enqueue(l);
        }
        return q.Peek();
    }
    
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        if(l1 == null) return l2;
        if(l2 == null) return l1;
        ListNode head = null;
        ListNode tail = null;
        while(l1 != null || l2 != null){
            if(l1 == null) {
                tail.next = l2;
                return head;
            } else if (l2 == null) {
                tail.next = l1;
                return head;
            } else if(l1.val < l2.val) {
                if(head == null){
                    tail = l1;
                    head = tail;
                } else {
                    tail.next = l1;
                    tail = l1;
                }
                l1 = l1.next;
            } else {
                if(head == null){
                    tail = l2;
                    head = tail;
                } else {
                    tail.next = l2;
                    tail = l2;
                }
                l2 = l2.next;
            }
        }
        return head;
    }
}
