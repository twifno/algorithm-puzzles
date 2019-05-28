//https://leetcode.com/problems/diameter-of-binary-tree/

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
    public int DiameterOfBinaryTree(TreeNode root) {
        int[] d = Depth(root);
        return d[1];
    }
    
    private int[] Depth(TreeNode root) {
        if(root == null) return new int[2] {-1, 0};
        int[] d1 = Depth(root.left);
        int[] d2 = Depth(root.right);
        int depth = Math.Max(d1[0], d2[0]) + 1;
        int dia = d1[0] + d2[0] + 2;
        dia = Math.Max(dia, d1[1]);
        dia = Math.Max(dia, d2[1]);
        return new int[2]{depth, dia};
    }
}
