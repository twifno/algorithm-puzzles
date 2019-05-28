//https://leetcode.com/problems/add-two-numbers-ii/

//Recurrsion

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    class Addition{
        public ListNode Node;
        public int Carry;
        public Addition(ListNode n, int c){
            Node = n;
            Carry = c;
        }
    }
    
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int len1 = GetLength(l1);
        int len2 = GetLength(l2);
        Addition a = (len1 >= len2)?Add(l1, len1, l2, len2):Add(l2, len2, l1, len1);
        if(a.Carry > 0) {
            ListNode head = new ListNode(a.Carry);
            head.next = a.Node;
            return head;
        } else {
            return a.Node;
        }
    }
    
    private int GetLength(ListNode list) {
        int len = 0;
        while(list != null) {
            len += 1;
            list = list.next;
        }
        return len;
    }
    
    private Addition Add(ListNode n1, int l1, ListNode n2, int l2) {
        if(l1 > l2) {
            Addition a = Add(n1.next, l1-1, n2, l2);
            int carry = (n1.val + a.Carry)/10;
            int val = (n1.val + a.Carry)%10;
            ListNode n = new ListNode(val);
            n.next = a.Node;
            Addition res = new Addition(n, carry);
            return res;
        } else {
            if(n1.next == null){
                int carry = (n1.val + n2.val)/10;
                int val = (n1.val + n2.val)%10;
                ListNode n = new ListNode(val);
                Addition res = new Addition(n, carry);
                return res;
            } else {
                Addition a = Add(n1.next, l1-1, n2.next, l2-1);
                int carry = (n1.val + n2.val + a.Carry)/10;
                int val = (n1.val + n2.val + a.Carry)%10;
                ListNode n = new ListNode(val);
                n.next = a.Node;
                Addition res = new Addition(n, carry);
                return res;
            }
        }
    }
}
