//https://leetcode.com/problems/linked-list-components/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int NumComponents(ListNode head, int[] G) {
        HashSet<int> hs = new HashSet<int>();
        foreach(int n in G) hs.Add(n);
        int count = 0;
        while(head != null){
            if(hs.Contains(head.val)) {
                if(head.next == null || !hs.Contains(head.next.val)) count += 1;
            }
            head = head.next;
        }
        return count;
    }
}
