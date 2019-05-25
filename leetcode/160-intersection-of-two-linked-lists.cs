//https://leetcode.com/problems/intersection-of-two-linked-lists/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        ListNode pa = headA;
        int counta = 0;
        while(pa != null) {
            pa = pa.next;
            counta += 1;
        }
        ListNode pb = headB;
        int countb = 0;
        while(pb != null) {
            pb = pb.next;
            countb += 1;
        }
        pa = headA;
        pb = headB;
        if(counta > countb){
            for(int i = 0; i < counta-countb; i++){
                pa = pa.next;
            }
        } else {
            for(int i = 0; i < countb-counta; i++){
                pb = pb.next;
            }
        }
        while(pa != null && pa != pb){
            pa = pa.next;
            pb = pb.next;
        }
        return pa;
    }
}
