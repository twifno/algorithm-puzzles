//https://leetcode.com/problems/delete-node-in-a-bst/

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
    public TreeNode DeleteNode(TreeNode root, int key) { 
        if(root == null) return null;
        TreeNode res = null;
        if(root.val == key){
            if(root.right != null){
                res = root.right;
                TreeNode n = root.right;
                while(n.left != null){
                    n = n.left;
                }
                n.left = root.left;
            } else {
                res = root.left;
            }
        } else {
            res = root;
            if(root.val > key) {
                TreeNode n = DeleteNode(root.left, key);
                root.left = n;
            } else {
                TreeNode n = DeleteNode(root.right, key);
                root.right = n;
            }
        }
        return res;
    }
}
