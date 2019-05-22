//https://leetcode.com/problems/symmetric-tree/

//Recursion…

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
    public bool IsSymmetric(TreeNode root) {
        return IsSym(root, root);
    }
    
    private bool IsSym(TreeNode r1, TreeNode r2){
        if(r1 == null && r2 == null) return true;
        if(r1 == null || r2 == null) return false;
        if(r1.val != r2.val) return false;
        return IsSym(r1.left, r2.right) && IsSym(r1.right, r2.left);
    }
}
