//https://leetcode.com/problems/inorder-successor-in-bst/

//Some tree recursion.

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
    public TreeNode InorderSuccessor(TreeNode root, TreeNode p) {
        if(root == null) return null;
        if(root.val <= p.val) return InorderSuccessor(root.right, p);
        if(root.left == null) return root;
        TreeNode target = InorderSuccessor(root.left, p);
        if(target == null) return root;
        return target;
    }
}
