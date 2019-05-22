//https://leetcode.com/problems/binary-tree-upside-down/

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
    public TreeNode UpsideDownBinaryTree(TreeNode root) {
        if(root == null || root.left == null) return root;
        TreeNode newRoot = UpsideDownBinaryTree(root.left);
        TreeNode right = newRoot;
        while(right.right != null){
            right = right.right;
        }
        right.left = root.right;
        root.left = null;
        root.right = null;
        right.right = root;
        return newRoot;
    }
}
