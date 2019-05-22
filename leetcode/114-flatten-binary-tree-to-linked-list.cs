//https://leetcode.com/problems/flatten-binary-tree-to-linked-list/

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
    public void Flatten(TreeNode root) {
        TreeNode tail;
        Build(root, out tail);
    }
    
    private void Build(TreeNode root, out TreeNode tail){
        tail = null;
        if(root == null) return;
        if(root.left == null && root.right == null) {
            tail = root;
            return;
        }
        TreeNode t1,t2;
        Build(root.left, out t1);
        Build(root.right, out t2);
        if(root.left != null) {
            t1.right = root.right;
            root.right = root.left;
            root.left = null;
        }
        tail = t1;
        if(t2 != null) tail = t2;
    }
}
