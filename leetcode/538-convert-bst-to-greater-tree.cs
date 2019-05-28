//https://leetcode.com/problems/convert-bst-to-greater-tree/

//Think it from the right most node!!!

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
    int Sum;
    
    public TreeNode ConvertBST(TreeNode root) {
        Sum = 0;
        Convert(root);
        return root;
    }
    
    private void Convert(TreeNode root) {
        if(root == null) return;
        Convert(root.right);
        Sum += root.val;
        root.val = Sum;
        Convert(root.left);
    }
}
