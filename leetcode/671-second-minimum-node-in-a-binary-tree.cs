//https://leetcode.com/problems/second-minimum-node-in-a-binary-tree/

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
    public int FindSecondMinimumValue(TreeNode root) {
        if(root == null) return -1;
        if(root.left == null) return -1;
        int left = root.left.val;
        if(left == root.val) left = FindSecondMinimumValue(root.left);
        int right = root.right.val;
        if(right == root.val) right = FindSecondMinimumValue(root.right);
        if(left == -1 && right == -1) return -1;
        if(left == -1) return right;
        if(right == -1) return left;
        return Math.Min(left, right);
    }
}
