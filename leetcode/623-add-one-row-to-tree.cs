//https://leetcode.com/problems/add-one-row-to-tree/

//Be care about d == 1

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
    public TreeNode AddOneRow(TreeNode root, int v, int d) {
        if(d == 1) {
            TreeNode node = new TreeNode(v);
            node.left = root;
            return node;
        }
        return AddOneRow(root, v, d, 1);
    }
    
    private TreeNode AddOneRow(TreeNode root, int v, int d, int cur){
        if(root == null) return null;
        if(d != cur+1) {
            AddOneRow(root.left, v, d, cur+1);
            AddOneRow(root.right, v, d, cur+1);
        } else {
            TreeNode left = new TreeNode(v);
            left.left = root.left;
            root.left = left;
            TreeNode right = new TreeNode(v);
            right.right = root.right;
            root.right = right;
        }
        return root;
    }
}
