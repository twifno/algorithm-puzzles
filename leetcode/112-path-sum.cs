//https://leetcode.com/problems/path-sum/

//Pay attention to the definition of leaf!

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
    public bool HasPathSum(TreeNode root, int sum) {
        if(root == null) return false;
        return Has(root, sum);
    }
    
    private bool Has(TreeNode root, int sum) {
        if(root.left == null && root.right == null){
            if(sum == root.val) return true;
            else return false;
        }
        return root.left != null && Has(root.left, sum-root.val) 
            || root.right != null && Has(root.right, sum-root.val);
    }
}

