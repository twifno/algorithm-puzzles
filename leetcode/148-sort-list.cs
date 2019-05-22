//https://leetcode.com/problems/sort-list/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SortList(ListNode head) {
        if(head == null || head.next == null) return head;
        ListNode fast = head;
        ListNode slow = head;
        while(fast.next != null && fast.next.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }
        //System.Console.WriteLine(head.val);
        
        ListNode sl1 = slow.next; 
        sl1 = SortList(sl1);
        slow.next = null;
        ListNode sl2 = SortList(head);
        head = null;
        ListNode tail = null;
        while(sl1 != null || sl2 != null){
            if(sl1 == null){
                if(head == null){
                    head = sl2;
                    return head;
                }else{
                    tail.next = sl2;
                    return head;
                }
            } else if(sl2 == null){
                if(head == null){
                    head = sl1;
                    return head;
                }else{
                    tail.next = sl1;
                    return head;
                } 
            } else {
                if(sl1.val > sl2.val){
                    if(head == null){
                        head = sl2;
                        tail = sl2;
                    }else{
                        tail.next = sl2;
                        tail = tail.next;
                    }
                    sl2 = sl2.next;
                    tail.next = null;
                } else {
                    if(head == null){
                        head = sl1;
                        tail = sl1;
                    }else{
                        tail.next = sl1;
                        tail = tail.next;
                    }
                    sl1 = sl1.next;
                    tail.next = null;
                }
            }
        }
        return head;
    }
}
