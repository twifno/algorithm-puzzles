//https://leetcode.com/problems/increasing-order-search-tree/

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
    public TreeNode IncreasingBST(TreeNode root) {
        if(root == null) return root;
        Stack<TreeNode> st = new Stack<TreeNode>();
        TreeNode prev = null;
        TreeNode head = null;
        TreeNode tmp = root;
        while(tmp != null) {
            st.Push(tmp);
            tmp = tmp.left;
        }
        while(st.Count > 0){
            TreeNode node = st.Pop();
            if(prev != null) prev.right = node;
            prev = node;
            if(head == null) head = node;
            TreeNode right = node.right;
            while(right != null) {
                st.Push(right);
                right = right.left;
            }
            node.left = null;
            node.right = null;
        }
        return head;
    }
}
