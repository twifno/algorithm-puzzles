//https://leetcode.com/problems/binary-tree-longest-consecutive-sequence/

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
    int Max;
    
    public int LongestConsecutive(TreeNode root) {
        Max = 0;
        Find(root);
        return Max;
    }
    
    private int Find(TreeNode root){
        if(root == null) return 0;
        int len = 1;
        int left = Find(root.left);
        if(root.left != null && root.left.val == root.val + 1){
            len = Math.Max(len, left + 1);
        }
        int right= Find(root.right);
        if(root.right != null && root.right.val == root.val + 1){
            len = Math.Max(len, right + 1);
        }
        Max = Math.Max(len, Max);
        return len;
    }
    
    
}
