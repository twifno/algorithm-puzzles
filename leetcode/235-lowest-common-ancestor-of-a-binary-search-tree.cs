//https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/

//Didn’t notice that it is a BST, but this still work

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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root == null) return null;
        if(root == p || root == q) return root;
        TreeNode left = LowestCommonAncestor(root.left, p, q);
        TreeNode right = LowestCommonAncestor(root.right, p, q);
        if(left == null && right == null){
            return null;
        } else if (left != null && right != null) {
            return root;
        } else if (left != null) return left;
        else return right;
    }
}
