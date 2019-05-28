//https://leetcode.com/problems/binary-tree-pruning/

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
    public TreeNode PruneTree(TreeNode root) {
        if(hasOne(root)) return root;
        return null;
    }
    
    public bool hasOne(TreeNode root){
        if(root == null) return false;
        bool left = hasOne(root.left);
        bool right = hasOne(root.right);
        if(!left && !right) {
            if(root.val == 0) return false;
            else {
                root.left = null;
                root.right = null;
                return true;
            }
        }
        if(!left) root.left = null;
        if(!right) root.right = null;
        return true;
    }
}
