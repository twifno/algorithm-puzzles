//https://leetcode.com/problems/odd-even-linked-list/

//Maintain an even head and an odd head..

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode OddEvenList(ListNode head) {
        ListNode odd = null;
        ListNode ocur = null;
        ListNode even = null;
        ListNode ecur = null;
        bool isOdd = true;
        while(head != null){
            if(isOdd){
                if(odd == null){
                    odd = head;
                    ocur = head;
                } else {
                    ocur.next = head;
                    ocur = head;
                }
                head = head.next;
                ocur.next = null;
            } else {
                if(even == null){
                    even = head;
                    ecur = head;
                } else {
                    ecur.next = head;
                    ecur = head;
                }
                head = head.next;
                ecur.next = null;
            }
            isOdd = !isOdd;
        }
        if(ocur != null) ocur.next = even;
        return odd;
    }
}
