//https://leetcode.com/problems/convert-sorted-list-to-binary-search-tree/

//It is a brilliant idea to move Node on each operation..

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    ListNode Node = null;
    
    public TreeNode SortedListToBST(ListNode head) {
        ListNode node = head;
        int count = 0;
        while(node != null) {
            count += 1;
            node = node.next;
        }
        Node = head;
        return Build(0, count);
    }
    
    public TreeNode Build(int left, int right){
        if(left >= right) return null;
        int mid = left + (right-left)/2;
        TreeNode leftNode = Build(left, mid);
        TreeNode node = new TreeNode(Node.val);
        Node = Node.next;
        node.left = leftNode;
        node.right = Build(mid+1, right);
        return node;
    }
}
